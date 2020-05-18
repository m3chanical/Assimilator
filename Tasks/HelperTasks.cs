using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Assimilator.GUI;
using Assimilator.Helpers;
using Buddy.Coroutines;
using ff14bot;
using ff14bot.Behavior;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.NeoProfiles;
using TreeSharp;
using Action = TreeSharp.Action;

namespace Assimilator.Tasks
{
    class HelperTasks
    {
        internal static uint Meal = 0;
        internal static bool ShouldEat = false;

        public static async Task<bool> EatFood()
        {

            if (GatheringManager.WindowOpen || Meal == 0 || !ShouldEat)
            {
                return true;
            }

            var item = InventoryManager.FilledSlots.GetFoodItem(Meal);

            if (item == null) return true;

            Logger.Info("Eating " + item.Name);
            item.UseItem();
            await Coroutine.Wait(5000, () => Core.Player.HasAura(48));

            return true;
        }

        public static async Task<bool> TeleportTask(ushort zone)
        {
            if (WorldManager.ZoneId == zone) return true;

            if (!WorldManager.AetheryteIdsForZone(zone).Any(aetheryte => WorldManager.HasAetheryteId(aetheryte.Item1))) {
                Logger.Error("No available teleport to this zone: " + Assimilator._nodestomine.First().ZoneId);
                TreeRoot.Stop();
            }
            foreach (var aetheryte in WorldManager.AetheryteIdsForZone((uint)Assimilator._nodestomine.First().ZoneId)) {
                Logger.Info("Teleporting to " + WorldManager.AvailableLocations.FirstOrDefault(z => z.ZoneId == Assimilator._nodestomine.First().ZoneId).Name + "...");
                WorldManager.TeleportById(aetheryte.Item1);
                await Coroutine.Wait(5000, () => !Core.Me.IsCasting && !CommonBehaviors.IsLoading);
                break;
            }
            return true;
        }
    }
}
