using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assimilator.Helpers;
using ff14bot.Managers;

namespace Assimilator.GUI
{
    public partial class SettingsWindow : Form
    {
        private Dictionary<uint, string> meals;
        public SettingsWindow() {
            meals = new Dictionary<uint, string>();
            InitializeComponent();
            UpdateFood();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            foreach (string log in Logger.LogList)
            {
                this.logList.Items.Add(log);
                
            }
        }

        private void gatheringTab_Click(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void addButton_Click(object sender, EventArgs e) {
            // get selected items from the datagrid
            // add to the list to the side
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tasks.HelperTasks.Meal = (uint) MealComboBox.SelectedValue;
        }

        private void TabControlSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Info("TabControl SelectedIndexChanged Event.");

            switch (TabControlSettings.SelectedIndex)
            {
                case 0: // general page
                    Logger.Info("general tab selected");
                    break;
                case 1: // gathering page
                    Logger.Info("gathering tab selected");
                    break;
                case 2: // log page
                    this.logList.Items.Clear();
                    foreach (string log in Logger.LogList) {
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
    }
}
