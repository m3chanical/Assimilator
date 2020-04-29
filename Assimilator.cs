using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Assimilator.GUI;
using Assimilator.Helpers;
using ff14bot.AClasses;
using ff14bot.Behavior;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.Pathing.Service_Navigation;
using ff14bot.RemoteWindows;
using TreeSharp;
using Action = TreeSharp.Action;
using Path = System.IO.Path;

namespace Assimilator
{

    public class Assimilator : BotBase
    {

        public override string Name => "Garlean Resource Assimilator";
        private Composite _root;
        public override PulseFlags PulseFlags => PulseFlags.All;
        public override bool RequiresProfile => false;
        public override bool IsAutonomous => true;
        public override bool WantButton => true;


        private SettingsWindow _settings;
        private readonly Version _v = new Version(0,0,1);

        public Assimilator()
        {
            Logger.Info("Assimilator Init Complete");
        }

        public override void OnButtonPress()
        {
            if (_settings == null)
            {
                _settings = new SettingsWindow {
                    Text = "Garlean Resource Assimilator v" + _v,
                };
                _settings.Closed += (o, e) => { _settings = null; };
            }

            try
            {
                _settings.Show();
            }
            catch (Exception)
            {
                // ignored
            }
        }



        public override void Stop()
        {
            Logger.Info("Cease Assimilation");
            return;
        }

        public override void Start()
        {   
            Logger.Verbose("Parsing Settings");
            SanityCheck();
            Logger.Verbose("Commencing Assimilation");
            Poi.Clear("Fresh Start");
            Poi.Current = null; //temp fix (??? Stolen from zzi)

            Navigator.NavigationProvider = new ServiceNavigationProvider();
            Navigator.PlayerMover = new SlideMover();

            TreeHooks.Instance.ClearAll();

        }

        private void SanityCheck()
        {
            // check settings to ensure there aren't any conflicts or other weird things
        }

        public Composite GetRoot() 
        {
            return Root;
        }

        public override Composite Root =>
            _root ?? (
                _root = new Tasks.MainTasks().MainTask
            );
    }

    public class Settings : JsonSettings
    {
        private static Settings _instance;
        public static Settings Instance => _instance ?? (_instance = new Settings());

        public Settings() : base(Path.Combine(CharacterSettingsDirectory, "Assimilator.json")) { }

    }

    //var newList = JsonConvert.DeserializeObject<List<GatheringNodeData>>(File.ReadAllText(Path.Combine("H:\\", $"TimedNodes.json")));
    //    foreach (var nodeData in newList)
    //    {
    //        Log($"\n{nodeData}");
    //     }
}
