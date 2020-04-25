using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using ff14bot.AClasses;
using ff14bot.Behavior;
using ff14bot.Helpers;
using ICSharpCode.SharpZipLib.Zip;
using Newtonsoft.Json;
using TreeSharp;
using Action = TreeSharp.Action;

namespace Assimilator
{
    public class AssimilatorLoader : BotBase
    {
        // Change this settings to reflect your project!
        private const string ProjectName = "Assimilator";
        private const int ProjectId = 2;
        private const string ProjectMainType = "Assimilator.Assimilator";
        private const string ProjectAssemblyName = "Assimilator.dll";
        private static readonly Color LogColor = Colors.LightGreen;
        public override PulseFlags PulseFlags => PulseFlags.All;
        public override bool IsAutonomous => true;
        public override bool WantButton => true;
        public override bool RequiresProfile => false;

        // Don't touch anything else below from here!
        private static readonly object locker = new object();
        private static readonly string ProjectAssembly = Path.Combine(Environment.CurrentDirectory, $@"BotBases\{ProjectName}\{ProjectAssemblyName}");
        private static readonly string GreyMagicAssembly = Path.Combine(Environment.CurrentDirectory, @"GreyMagic.dll");
        private static readonly string MahappsAssembly = Path.Combine(Environment.CurrentDirectory, $@"BotBases\{ProjectName}\MahApps.Metro.dll");
        private static readonly string BaseDir = Path.Combine(Environment.CurrentDirectory, $@"BotBases\{ProjectName}");
        private static readonly string ProjectTypeFolder = Path.Combine(Environment.CurrentDirectory, @"BotBases");
        private static volatile bool loaderStarted, loaded;

        public AssimilatorLoader()
        {
            if (loaderStarted)
            {
                return;
            }

            loaderStarted = true;
            Task.Factory.StartNew(LoadProduct);

        }

        private static object Product { get; set; }

        private static MethodInfo StartFunc { get; set; }

        private static MethodInfo StopFunc { get; set; }

        private static MethodInfo ButtonFunc { get; set; }

        private static MethodInfo RootFunc { get; set; }

        public override string Name => ProjectName;

        public override Composite Root {
            get {
                if (!loaded && Product == null) { LoadProduct(); }
                return Product != null ? (Composite)RootFunc.Invoke(Product, null) : new Action();
            }
        }

        public override void OnButtonPress() {
            if (!loaded && Product == null) { LoadProduct(); }
            if (Product != null) { ButtonFunc.Invoke(Product, null); }
        }

        public override void Start() {
            if (!loaded && Product == null) { LoadProduct(); }
            if (Product != null) { StartFunc.Invoke(Product, null); }
        }

        public override void Stop() {
            if (!loaded && Product == null) { LoadProduct(); }
            if (Product != null) { StopFunc.Invoke(Product, null); }
        }

        public static void RedirectAssembly() {
            ResolveEventHandler handler = (sender, args) => {
                string name = Assembly.GetEntryAssembly().GetName().Name;
                var requestedAssembly = new AssemblyName(args.Name);
                return requestedAssembly.Name != name ? null : Assembly.GetEntryAssembly();
            };

            AppDomain.CurrentDomain.AssemblyResolve += handler;

            ResolveEventHandler greyMagicHandler = (sender, args) => {
                var requestedAssembly = new AssemblyName(args.Name);
                return requestedAssembly.Name != "GreyMagic" ? null : Assembly.LoadFrom(GreyMagicAssembly);
            };

            AppDomain.CurrentDomain.AssemblyResolve += greyMagicHandler;

            Assembly mahappsHandler(object sender, ResolveEventArgs args) {
                var requestedAssembly = new AssemblyName(args.Name);
                return requestedAssembly.Name != "MahApps.Metro" ? null : Assembly.LoadFrom(MahappsAssembly);
            }

            AppDomain.CurrentDomain.AssemblyResolve += mahappsHandler;
        }

        private static Assembly LoadAssembly(string path) {
            if (!File.Exists(path)) { return null; }

            Assembly assembly = null;
            try { assembly = Assembly.LoadFrom(path); } catch (Exception e) { Logging.WriteException(e); }

            return assembly;
        }

        private static object Load() {
            RedirectAssembly();

            var assembly = LoadAssembly(ProjectAssembly);
            if (assembly == null) { return null; }

            Type baseType;
            try { baseType = assembly.GetType(ProjectMainType); } catch (Exception e) {
                Log(e.ToString());
                return null;
            }

            object bb;
            try { bb = Activator.CreateInstance(baseType); } catch (Exception e) {
                Log(e.ToString());
                return null;
            }

            if (bb != null) { Log(ProjectName + " was loaded successfully."); } else { Log("Could not load " + ProjectName + ". This can be due to a new version of Rebornbuddy being released. An update should be ready soon."); }

            return bb;
        }

        private static void LoadProduct() {
            lock (locker) {
                if (Product != null) { return; }
                Product = Load();
                loaded = true;
                if (Product == null) { return; }

                StartFunc = Product.GetType().GetMethod("Start");
                StopFunc = Product.GetType().GetMethod("Stop");
                ButtonFunc = Product.GetType().GetMethod("OnButtonPress");
                RootFunc = Product.GetType().GetMethod("GetRoot");
                loaderStarted = false;
            }
        }

        private static void Log(string message) {
            message = "[Project Loader][" + ProjectName + "] " + message;
            Logging.Write(LogColor, message);
        }

    }
}