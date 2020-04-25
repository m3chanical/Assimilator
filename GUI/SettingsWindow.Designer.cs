namespace Assimilator.GUI
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.TabControlSettings = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MealComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botanistGearset = new System.Windows.Forms.NumericUpDown();
            this.minerGearset = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gatheringTab = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hq = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.logTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.logList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TabControlSettings.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botanistGearset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minerGearset)).BeginInit();
            this.gatheringTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.logTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlSettings
            // 
            this.TabControlSettings.Controls.Add(this.generalTab);
            this.TabControlSettings.Controls.Add(this.gatheringTab);
            this.TabControlSettings.Controls.Add(this.logTab);
            this.TabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlSettings.Location = new System.Drawing.Point(0, 0);
            this.TabControlSettings.Name = "TabControlSettings";
            this.TabControlSettings.SelectedIndex = 0;
            this.TabControlSettings.Size = new System.Drawing.Size(800, 450);
            this.TabControlSettings.TabIndex = 0;
            this.TabControlSettings.SelectedIndexChanged += new System.EventHandler(this.TabControlSettings_SelectedIndexChanged);
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.button1);
            this.generalTab.Controls.Add(this.groupBox2);
            this.generalTab.Controls.Add(this.groupBox1);
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTab.Size = new System.Drawing.Size(792, 424);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MealComboBox);
            this.groupBox2.Location = new System.Drawing.Point(131, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 65);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food";
            // 
            // MealComboBox
            // 
            this.MealComboBox.FormattingEnabled = true;
            this.MealComboBox.Location = new System.Drawing.Point(6, 23);
            this.MealComboBox.Name = "MealComboBox";
            this.MealComboBox.Size = new System.Drawing.Size(121, 21);
            this.MealComboBox.TabIndex = 6;
            this.MealComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.MealComboBox.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botanistGearset);
            this.groupBox1.Controls.Add(this.minerGearset);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gearsets";
            // 
            // botanistGearset
            // 
            this.botanistGearset.Location = new System.Drawing.Point(71, 45);
            this.botanistGearset.Name = "botanistGearset";
            this.botanistGearset.Size = new System.Drawing.Size(35, 20);
            this.botanistGearset.TabIndex = 4;
            // 
            // minerGearset
            // 
            this.minerGearset.Location = new System.Drawing.Point(71, 24);
            this.minerGearset.Name = "minerGearset";
            this.minerGearset.Size = new System.Drawing.Size(35, 20);
            this.minerGearset.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(6, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(59, 13);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Botanist";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 13);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Miner";
            // 
            // gatheringTab
            // 
            this.gatheringTab.Controls.Add(this.groupBox6);
            this.gatheringTab.Controls.Add(this.groupBox5);
            this.gatheringTab.Controls.Add(this.dataGridView1);
            this.gatheringTab.Location = new System.Drawing.Point(4, 22);
            this.gatheringTab.Name = "gatheringTab";
            this.gatheringTab.Padding = new System.Windows.Forms.Padding(3);
            this.gatheringTab.Size = new System.Drawing.Size(792, 424);
            this.gatheringTab.TabIndex = 1;
            this.gatheringTab.Text = "Gathering";
            this.gatheringTab.UseVisualStyleBackColor = true;
            this.gatheringTab.Click += new System.EventHandler(this.gatheringTab_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.addButton);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(786, 39);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(705, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listView1);
            this.groupBox5.Location = new System.Drawing.Point(558, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(231, 373);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "To Assimilate";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(225, 354);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.level,
            this.item,
            this.job,
            this.time,
            this.amount,
            this.hq});
            this.dataGridView1.Location = new System.Drawing.Point(3, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 379);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // level
            // 
            this.level.HeaderText = "Level";
            this.level.Name = "level";
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            // 
            // job
            // 
            this.job.HeaderText = "Job";
            this.job.Name = "job";
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // hq
            // 
            this.hq.HeaderText = "HQ";
            this.hq.Name = "hq";
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.groupBox4);
            this.logTab.Controls.Add(this.groupBox3);
            this.logTab.Location = new System.Drawing.Point(4, 22);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Windows.Forms.Padding(3);
            this.logTab.Size = new System.Drawing.Size(792, 424);
            this.logTab.TabIndex = 2;
            this.logTab.Text = "Log";
            this.logTab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.logList);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 418);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log";
            // 
            // logList
            // 
            this.logList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logList.FormattingEnabled = true;
            this.logList.Location = new System.Drawing.Point(3, 16);
            this.logList.Name = "logList";
            this.logList.Size = new System.Drawing.Size(346, 399);
            this.logList.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(355, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 418);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControlSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.Text = "SettingsWindow";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.TabControlSettings.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botanistGearset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minerGearset)).EndInit();
            this.gatheringTab.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.logTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlSettings;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.TabPage gatheringTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox MealComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown botanistGearset;
        private System.Windows.Forms.NumericUpDown minerGearset;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox logList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn job;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hq;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listView1;
    }
}