﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Assimilator.Helpers;
using Buddy.Coroutines;
using ff14bot;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.NeoProfiles;
using TreeSharp;
using Action = TreeSharp.Action;

namespace Assimilator.Tasks
{
    class HelperTasks
    {
        internal static uint Meal;

        public static async Task<bool> EatFood()
        {
            //change this to composite

            if (GatheringManager.WindowOpen)
            {
                return false;
            }

            var item = InventoryManager.FilledSlots.GetFoodItem(Meal);

            if (item == null) return false;

            Logger.Info("Eating " + item.Name);
            item.UseItem();
            await Coroutine.Wait(5000, () => Core.Player.HasAura(48));

            return true;
        }
    }
}