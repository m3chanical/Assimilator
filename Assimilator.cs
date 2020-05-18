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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ff14bot.Managers;
using ff14bot.NeoProfiles;
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
        public static List<TimedNode> _nodestomine = new List<TimedNode>();

        public Assimilator()
        {
            _database = JsonConvert.DeserializeObject<TimedNodesDataBase>(File.ReadAllText(@"BotBases\Assimilator\TimedNodes.json"));
            foreach (var node in _database.TimedNodes)
            {
                node.ItemName = DataManager.GetItem(node.ItemId).CurrentLocaleName;
            }
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
            Logger.Verbose("Commencing Assimilation");
            Poi.Clear("Fresh Start");
            Poi.Current = null; //temp fix (??? Stolen from zzi)

            Navigator.NavigationProvider = new ServiceNavigationProvider();
            Navigator.PlayerMover = new SlideMover();

            _nodestomine.Add(_database.TimedNodes.Find(n => n.ItemId == 7610));
            Logger.Verbose(
                $"Looking for a node between {Assimilator._nodestomine.First().TimeSlots.First().Key} and {Assimilator._nodestomine.First().TimeSlots.First().Value}.");
            Logger.Verbose($"Is time between {Assimilator._nodestomine.First().TimeSlots.First().Key} and {Assimilator._nodestomine.First().TimeSlots.First().Value}: {ConditionParser.IsTimeBetween(Assimilator._nodestomine.First().TimeSlots.First().Key, Assimilator._nodestomine.First().TimeSlots.First().Value) || ConditionParser.IsTimeBetween(Assimilator._nodestomine.First().TimeSlots.Last().Key, Assimilator._nodestomine.First().TimeSlots.Last().Value)}");
            TreeHooks.Instance.ClearAll();
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
