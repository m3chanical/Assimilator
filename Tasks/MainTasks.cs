using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assimilator.Helpers;
using Buddy.Coroutines;
using ff14bot;
using ff14bot.Behavior;
using ff14bot.Managers;
using ff14bot.NeoProfiles;
using TreeSharp;
using Action = TreeSharp.Action;

namespace Assimilator.Tasks
{
    class MainTasks
    {
        internal static bool Gathering = false; // if in the process of gathering, don't gather anything else.

        public PrioritySelector MainTask = new PrioritySelector(
            new Decorator(r => !Core.Me.HasAura(48), 
                new ActionRunCoroutine(async r =>
                {
                    await HelperTasks.EatFood();
                })),
            new Decorator(r => ConditionParser.IsTimeBetween(Assimilator._nodestomine.First().TimeSlots.First().Key, Assimilator._nodestomine.First().TimeSlots.First().Value) || ConditionParser.IsTimeBetween(Assimilator._nodestomine.First().TimeSlots.Last().Key, Assimilator._nodestomine.First().TimeSlots.Last().Value),
                new Sequence(
                    new Action(r => Logger.Info($"The Eorzean time is between {Assimilator._nodestomine.First().TimeSlots.First().Key} and {Assimilator._nodestomine.First().TimeSlots.First().Value}.")),
                    new Decorator(r => !Core.Me.IsCasting && WorldManager.CanTeleport(),
                        new ActionRunCoroutine(async r =>
                            {
                                await HelperTasks.TeleportTask(Assimilator._nodestomine.First().ZoneId);
                            })
                        )
                    )
                )
        );
    }
}
