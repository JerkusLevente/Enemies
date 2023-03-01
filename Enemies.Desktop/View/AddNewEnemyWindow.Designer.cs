namespace Enemies.Desktop.View
{
    partial class AddNewEnemyWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.UnitTypeLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.UnitTypeComboBoxAdd = new System.Windows.Forms.ComboBox();
            this.HealthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelAddWindowButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HealthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // UnitTypeLabel
            // 
            this.UnitTypeLabel.AutoSize = true;
            this.UnitTypeLabel.Location = new System.Drawing.Point(12, 37);
            this.UnitTypeLabel.Name = "UnitTypeLabel";
            this.UnitTypeLabel.Size = new System.Drawing.Size(31, 15);
            this.UnitTypeLabel.TabIndex = 2;
            this.UnitTypeLabel.Text = "Type";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Location = new System.Drawing.Point(12, 69);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(42, 15);
            this.HealthLabel.TabIndex = 4;
            this.HealthLabel.Text = "Health";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(12, 97);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(39, 15);
            this.SpeedLabel.TabIndex = 6;
            this.SpeedLabel.Text = "Speed";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(12, 127);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(35, 15);
            this.ValueLabel.TabIndex = 8;
            this.ValueLabel.Text = "Value";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(57, 6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(141, 23);
            this.NameTextBox.TabIndex = 9;
            // 
            // UnitTypeComboBoxAdd
            // 
            this.UnitTypeComboBoxAdd.FormattingEnabled = true;
            this.UnitTypeComboBoxAdd.Location = new System.Drawing.Point(57, 34);
            this.UnitTypeComboBoxAdd.Name = "UnitTypeComboBoxAdd";
            this.UnitTypeComboBoxAdd.Size = new System.Drawing.Size(141, 23);
            this.UnitTypeComboBoxAdd.TabIndex = 10;
            // 
            // HealthNumericUpDown
            // 
            this.HealthNumericUpDown.Location = new System.Drawing.Point(57, 66);
            this.HealthNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.HealthNumericUpDown.Name = "HealthNumericUpDown";
            this.HealthNumericUpDown.Size = new System.Drawing.Size(141, 23);
            this.HealthNumericUpDown.TabIndex = 11;
            // 
            // SpeedNumericUpDown
            // 
            this.SpeedNumericUpDown.Location = new System.Drawing.Point(57, 95);
            this.SpeedNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.SpeedNumericUpDown.Name = "SpeedNumericUpDown";
            this.SpeedNumericUpDown.Size = new System.Drawing.Size(141, 23);
            this.SpeedNumericUpDown.TabIndex = 12;
            // 
            // ValueNumericUpDown
            // 
            this.ValueNumericUpDown.Location = new System.Drawing.Point(58, 124);
            this.ValueNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ValueNumericUpDown.Name = "ValueNumericUpDown";
            this.ValueNumericUpDown.Size = new System.Drawing.Size(140, 23);
            this.ValueNumericUpDown.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(24, 162);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(52, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelAddWindowButton
            // 
            this.CancelAddWindowButton.Location = new System.Drawing.Point(142, 162);
            this.CancelAddWindowButton.Name = "CancelAddWindowButton";
            this.CancelAddWindowButton.Size = new System.Drawing.Size(56, 23);
            this.CancelAddWindowButton.TabIndex = 15;
            this.CancelAddWindowButton.Text = "Cancel";
            this.CancelAddWindowButton.UseVisualStyleBackColor = true;
            this.CancelAddWindowButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(82, 162);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(54, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddNewEnemyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 202);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelAddWindowButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ValueNumericUpDown);
            this.Controls.Add(this.SpeedNumericUpDown);
            this.Controls.Add(this.HealthNumericUpDown);
            this.Controls.Add(this.UnitTypeComboBoxAdd);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.UnitTypeLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddNewEnemyWindow";
            this.Text = "Add New Enemy";
            ((System.ComponentModel.ISupportInitialize)(this.HealthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private Label UnitTypeLabel;
        private Label HealthLabel;
        private Label SpeedLabel;
        private Label ValueLabel;
        private TextBox NameTextBox;
        private ComboBox UnitTypeComboBoxAdd;
        private NumericUpDown HealthNumericUpDown;
        private NumericUpDown SpeedNumericUpDown;
        private NumericUpDown ValueNumericUpDown;
        private Button AddButton;
        private Button CancelAddWindowButton;
        private Button DeleteButton;
    }
}