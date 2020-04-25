using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ff14bot.Enums;
using ff14bot.Managers;

namespace Assimilator
{
    public static class Utils
    {
        // the below is obtained from Athlon's RBTrust addon
        private static bool IsFoodItem(this BagSlot slot) => (slot.Item.EquipmentCatagory == ItemUiCategory.Meal || slot.Item.EquipmentCatagory == ItemUiCategory.Ingredient);
        public static IEnumerable<BagSlot> GetFoodItems(this IEnumerable<BagSlot> bags) => bags.Where(s => s.IsFoodItem());
        public static bool ContainsFoodItem(this IEnumerable<BagSlot> bags, uint id) => bags.Select(s => s.TrueItemId).Contains(id);
        public static BagSlot GetFoodItem(this IEnumerable<BagSlot> bags, uint id) => bags.First(s => s.TrueItemId == id);
    }
}
