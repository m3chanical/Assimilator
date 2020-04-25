using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assimilator.Helpers;
using ff14bot;
using ff14bot.NeoProfiles;
using TreeSharp;
using Action = TreeSharp.Action;

namespace Assimilator.Tasks
{
    class MainTasks
    {
        // This MainTask holds the bulk of the logic for gathering. Aww yeah.
        public PrioritySelector MainTask = new PrioritySelector(
            new Decorator(r => !Core.Me.HasAura(48), 
                new ActionRunCoroutine(async r =>
                {
                    await HelperTasks.EatFood();
                })),
            new Decorator(r => ConditionParser.IsTimeBetween(12, 24),
                new Action(r =>
                {
                    Logger.Info("The Eorzean time is between 12 and 24.");
                })),
            new Decorator(r => ConditionParser.IsTimeBetween(0, 12),
                new Action(r =>
                {
                    Logger.Info("The Eorzean time is between 0 and 12.");
                }))
            );
    }
}
