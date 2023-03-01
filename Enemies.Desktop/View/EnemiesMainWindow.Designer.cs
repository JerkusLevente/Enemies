namespace Enemies.Desktop
{
    partial class EnemiesMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewEnemyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEnemiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEnemiesByTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnitTypeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.getEnemiesByMinimumMaximumValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEnemiesByMinimumMaximumValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEnemiesByValueHealthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumberOfEnemiesListedLabel = new System.Windows.Forms.Label();
            this.GreaterThanNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ListEnemiesWithValueGT = new System.Windows.Forms.Button();
            this.ListEnemiesWithValueLesserThanButton = new System.Windows.Forms.Button();
            this.NumberOfEnemiesListedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ListEnemiesByValueBetweenButton = new System.Windows.Forms.Button();
            this.ListEnemiesWithValueLesserThanNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreaterThanNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfEnemiesListedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListEnemiesWithValueLesserThanNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEnemyToolStripMenuItem,
            this.listEnemiesToolStripMenuItem,
            this.listEnemiesByTypeToolStripMenuItem,
            this.UnitTypeComboBox,
            this.getEnemiesByMinimumMaximumValueToolStripMenuItem,
            this.listEnemiesByMinimumMaximumValueToolStripMenuItem,
            this.listEnemiesByValueHealthToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewEnemyToolStripMenuItem
            // 
            this.addNewEnemyToolStripMenuItem.Name = "addNewEnemyToolStripMenuItem";
            this.addNewEnemyToolStripMenuItem.Size = new System.Drawing.Size(107, 23);
            this.addNewEnemyToolStripMenuItem.Text = "Add New Enemy";
            this.addNewEnemyToolStripMenuItem.Click += new System.EventHandler(this.addNewEnemyToolStripMenuItem_Click);
            // 
            // listEnemiesToolStripMenuItem
            // 
            this.listEnemiesToolStripMenuItem.Name = "listEnemiesToolStripMenuItem";
            this.listEnemiesToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.listEnemiesToolStripMenuItem.Text = "List Enemies";
            this.listEnemiesToolStripMenuItem.Click += new System.EventHandler(this.listEnemiesToolStripMenuItem_Click);
            // 
            // listEnemiesByTypeToolStripMenuItem
            // 
            this.listEnemiesByTypeToolStripMenuItem.Name = "listEnemiesByTypeToolStripMenuItem";
            this.listEnemiesByTypeToolStripMenuItem.Size = new System.Drawing.Size(127, 23);
            this.listEnemiesByTypeToolStripMenuItem.Text = "List Enemies By Type";
            this.listEnemiesByTypeToolStripMenuItem.Click += new System.EventHandler(this.listEnemiesByTypeToolStripMenuItem_Click);
            // 
            // UnitTypeComboBox
            // 
            this.UnitTypeComboBox.Name = "UnitTypeComboBox";
            this.UnitTypeComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // getEnemiesByMinimumMaximumValueToolStripMenuItem
            // 
            this.getEnemiesByMinimumMaximumValueToolStripMenuItem.Name = "getEnemiesByMinimumMaximumValueToolStripMenuItem";
            this.getEnemiesByMinimumMaximumValueToolStripMenuItem.Size = new System.Drawing.Size(12, 23);
            // 
            // listEnemiesByMinimumMaximumValueToolStripMenuItem
            // 
            this.listEnemiesByMinimumMaximumValueToolStripMenuItem.Name = "listEnemiesByMinimumMaximumValueToolStripMenuItem";
            this.listEnemiesByMinimumMaximumValueToolStripMenuItem.Size = new System.Drawing.Size(304, 23);
            this.listEnemiesByMinimumMaximumValueToolStripMenuItem.Text = "Sort Enemies in Descending/Ascending order By Value";
            this.listEnemiesByMinimumMaximumValueToolStripMenuItem.Click += new System.EventHandler(this.listEnemiesByMinimumMaximumValueToolStripMenuItem_Click);
            // 
            // listEnemiesByValueHealthToolStripMenuItem
            // 
            this.listEnemiesByValueHealthToolStripMenuItem.Name = "listEnemiesByValueHealthToolStripMenuItem";
            this.listEnemiesByValueHealthToolStripMenuItem.Size = new System.Drawing.Size(171, 23);
            this.listEnemiesByValueHealthToolStripMenuItem.Text = "List Enemies By Value/Health";
            this.listEnemiesByValueHealthToolStripMenuItem.Click += new System.EventHandler(this.listEnemiesByValueHealthToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1169, 367);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumberOfEnemiesListedLabel
            // 
            this.NumberOfEnemiesListedLabel.AutoSize = true;
            this.NumberOfEnemiesListedLabel.Location = new System.Drawing.Point(12, 412);
            this.NumberOfEnemiesListedLabel.Name = "NumberOfEnemiesListedLabel";
            this.NumberOfEnemiesListedLabel.Size = new System.Drawing.Size(152, 15);
            this.NumberOfEnemiesListedLabel.TabIndex = 2;
            this.NumberOfEnemiesListedLabel.Text = "Number of Enemies Listed :";
            // 
            // GreaterThanNumericUpDown
            // 
            this.GreaterThanNumericUpDown.Location = new System.Drawing.Point(461, 426);
            this.GreaterThanNumericUpDown.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.GreaterThanNumericUpDown.Name = "GreaterThanNumericUpDown";
            this.GreaterThanNumericUpDown.Size = new System.Drawing.Size(71, 23);
            this.GreaterThanNumericUpDown.TabIndex = 3;
            // 
            // ListEnemiesWithValueGT
            // 
            this.ListEnemiesWithValueGT.Location = new System.Drawing.Point(201, 423);
            this.ListEnemiesWithValueGT.Name = "ListEnemiesWithValueGT";
            this.ListEnemiesWithValueGT.Size = new System.Drawing.Size(254, 26);
            this.ListEnemiesWithValueGT.TabIndex = 4;
            this.ListEnemiesWithValueGT.Text = "List Enemies With Value greater than";
            this.ListEnemiesWithValueGT.UseVisualStyleBackColor = true;
            this.ListEnemiesWithValueGT.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListEnemiesWithValueLesserThanButton
            // 
            this.ListEnemiesWithValueLesserThanButton.Location = new System.Drawing.Point(854, 426);
            this.ListEnemiesWithValueLesserThanButton.Name = "ListEnemiesWithValueLesserThanButton";
            this.ListEnemiesWithValueLesserThanButton.Size = new System.Drawing.Size(254, 23);
            this.ListEnemiesWithValueLesserThanButton.TabIndex = 5;
            this.ListEnemiesWithValueLesserThanButton.Text = "List Enemies with value lesser than";
            this.ListEnemiesWithValueLesserThanButton.UseVisualStyleBackColor = true;
            this.ListEnemiesWithValueLesserThanButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // NumberOfEnemiesListedNumericUpDown
            // 
            this.NumberOfEnemiesListedNumericUpDown.Location = new System.Drawing.Point(12, 430);
            this.NumberOfEnemiesListedNumericUpDown.Name = "NumberOfEnemiesListedNumericUpDown";
            this.NumberOfEnemiesListedNumericUpDown.Size = new System.Drawing.Size(152, 23);
            this.NumberOfEnemiesListedNumericUpDown.TabIndex = 6;
            // 
            // ListEnemiesByValueBetweenButton
            // 
            this.ListEnemiesByValueBetweenButton.Location = new System.Drawing.Point(550, 426);
            this.ListEnemiesByValueBetweenButton.Name = "ListEnemiesByValueBetweenButton";
            this.ListEnemiesByValueBetweenButton.Size = new System.Drawing.Size(192, 23);
            this.ListEnemiesByValueBetweenButton.TabIndex = 7;
            this.ListEnemiesByValueBetweenButton.Text = "List Enemies By Value inbetween values";
            this.ListEnemiesByValueBetweenButton.UseVisualStyleBackColor = true;
            this.ListEnemiesByValueBetweenButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListEnemiesWithValueLesserThanNumericUpDown
            // 
            this.ListEnemiesWithValueLesserThanNumericUpDown.Location = new System.Drawing.Point(748, 426);
            this.ListEnemiesWithValueLesserThanNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ListEnemiesWithValueLesserThanNumericUpDown.Name = "ListEnemiesWithValueLesserThanNumericUpDown";
            this.ListEnemiesWithValueLesserThanNumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.ListEnemiesWithValueLesserThanNumericUpDown.TabIndex = 8;
            // 
            // EnemiesMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 476);
            this.Controls.Add(this.ListEnemiesWithValueLesserThanNumericUpDown);
            this.Controls.Add(this.ListEnemiesByValueBetweenButton);
            this.Controls.Add(this.NumberOfEnemiesListedNumericUpDown);
            this.Controls.Add(this.ListEnemiesWithValueLesserThanButton);
            this.Controls.Add(this.ListEnemiesWithValueGT);
            this.Controls.Add(this.GreaterThanNumericUpDown);
            this.Controls.Add(this.NumberOfEnemiesListedLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EnemiesMainWindow";
            this.Text = "Enemies Main Window";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreaterThanNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfEnemiesListedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListEnemiesWithValueLesserThanNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listEnemiesToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label NumberOfEnemiesListedLabel;
        private ToolStripMenuItem listEnemiesByTypeToolStripMenuItem;
        private ToolStripComboBox UnitTypeComboBox;
        private ToolStripMenuItem getEnemiesByMinimumMaximumValueToolStripMenuItem;
        private ToolStripMenuItem listEnemiesByMinimumMaximumValueToolStripMenuItem;
        private NumericUpDown GreaterThanNumericUpDown;
        private Button ListEnemiesWithValueGT;
        private Button ListEnemiesWithValueLesserThanButton;
        private NumericUpDown NumberOfEnemiesListedNumericUpDown;
        private Button ListEnemiesByValueBetweenButton;
        private NumericUpDown ListEnemiesWithValueLesserThanNumericUpDown;
        private ToolStripMenuItem listEnemiesByValueHealthToolStripMenuItem;
        private ToolStripMenuItem addNewEnemyToolStripMenuItem;
    }
}