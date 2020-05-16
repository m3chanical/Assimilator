using Assimilator.GUI;
using Assimilator.Helpers;
using Assimilator.Models;
using ff14bot.AClasses;
using ff14bot.Behavior;
using ff14bot.Helpers;
using ff14bot.Navigation;
using ff14bot.Pathing.Service_Navigation;
using Newtonsoft.Json;
using System;
using System.IO;
using ff14bot.Managers;
using TreeSharp;

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
        private readonly Version _v = new Version(0,0,2);

        public static TimedNodesDataBase _database; 

        public Assimilator()
        {
            _database = JsonConvert.DeserializeObject<TimedNodesDataBase>(File.ReadAllText(@"BotBases\Assimilator\TimedNodes.json"));
            Logger.Info("Assimilator Init Complete");

        }

        public override void OnButtonPress()
        {
            if (_settings == null)
            {
                _settings = new SettingsWindow {
                    Text = "Garlean Resource Assimilator v" + _v,
                    //_database = _database,
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
}
