using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assimilator.Helpers;
using Assimilator.Models;
using Assimilator.Tasks;
using ff14bot.Managers;
using QuickGraph;

namespace Assimilator.GUI
{
    public partial class SettingsWindow : Form
    {
        private Dictionary<uint, string> meals;

        internal TimedNodesDataBase _database { get; set; }

        public SettingsWindow() {
            meals = new Dictionary<uint, string>();
            InitializeComponent();
            UpdateFood();
            Tasks.HelperTasks.ShouldEat = shouldEat.Checked;
            if (Assimilator._database != null) timedNodeDataGrid.DataSource = Assimilator._database.TimedNodes;
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            foreach (string log in Logger.LogList.Take(50))
            {
                this.logList.Items.Add(log);
            }
        }

        private void gatheringTab_Click(object sender, EventArgs e) {

        }

        private void addButton_Click(object sender, EventArgs e) {
            // get selected items from the datagrid
            // add to the list to the side
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tasks.HelperTasks.Meal = MealComboBox.SelectedIndex == -1 ? 0 : (uint) MealComboBox.SelectedValue;
        }

        private void TabControlSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Logger.Info("TabControl SelectedIndexChanged Event.");

            switch (TabControlSettings.SelectedIndex)
            {
                case 0: // general page
                    //Logger.Info("general tab selected");
                    break;
                case 1: // gathering page
                    //Logger.Info("gathering tab selected");
                    break;
                case 2: // log page
                    this.logList.Items.Clear();
                    foreach (string log in Logger.LogList.Take(50).ToList()) {
                        this.logList.Items.Add(log);
                    }
                    break; 

            }
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            UpdateFood();
        }

        private void UpdateFood() 
        {
            meals.Clear();

            foreach (var item in InventoryManager.FilledSlots.GetFoodItems())
            {
                meals[item.TrueItemId] = item.Name + (item.IsHighQuality ? " HQ" : "");
            }

            MealComboBox.DataSource = new BindingSource(meals, null);
            MealComboBox.DisplayMember = "Value";
            MealComboBox.ValueMember = "Key";

        }

        private void UpdateLog()
        {
            // TODO: move log update stuff
        }

        private void shouldEat_CheckedChanged(object sender, EventArgs e)
        {
            HelperTasks.ShouldEat = shouldEat.Checked;
        }

    }
}
