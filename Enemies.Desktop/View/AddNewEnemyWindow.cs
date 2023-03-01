using Enemies.Core.Models;
using Enemies.Desktop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enemies.Desktop.View
{
    public partial class AddNewEnemyWindow : Form
    {
        private IEnemiesDao dao;
        private Enemy enemy;
        private bool IsModification=false;
        private readonly int enemyID;
        private float enemyHealthValue;

        public AddNewEnemyWindow(IEnemiesDao dao)
        {
            this.dao = dao;
            InitializeComponent();
            UnitTypeComboBoxAdd.Items.AddRange(new string[] {
                "Aerial",
                "Ground",
                });
            DeleteButton.Hide();
        }

        public AddNewEnemyWindow(IEnemiesDao dao, Enemy enemy): this(dao)
        {
            IsModification = true;
            AddButton.Text = "Save";
            DeleteButton.Show();
            enemyID = enemy.Id;

            NameTextBox.Text = enemy.Name;
            if (enemy.Type == UnitType.Aerial)
            {
                UnitTypeComboBoxAdd.Text = "Aerial";
            }
            else
            {
                UnitTypeComboBoxAdd.Text = "Ground";
            }
            HealthNumericUpDown.Hide();
            enemyHealthValue = enemy.Health;
            SpeedNumericUpDown.Value = enemy.Speed;
            ValueNumericUpDown.Value = enemy.Value;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = NameTextBox.Text;
            int Type = 0;
            string UnitType = UnitTypeComboBoxAdd.Text;
            if (UnitType == "Aerial")
            {
                Type = 1 << 0;
            }
            else if (UnitType == "Ground")
            {
                Type = 1 << 1;
            }

            float Health = (int)HealthNumericUpDown.Value;
            int Speed = (int)SpeedNumericUpDown.Value;
            int Value = (int)ValueNumericUpDown.Value;

            this.enemy = new Enemy
            {
                Name = Name,
                Type = (UnitType)Type,
                Health = Health,
                Speed = Speed,
                Value = Value,
            };

            if (IsModification)
            {
                enemy.Id = enemyID;
                enemy.Health = enemyHealthValue;
                dao.ModifyEnemy(enemy);
            }else
            {
            dao.AddEnemy(enemy);
            }


            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dao.DeleteEnemy(enemyID);
            this.Close();
        }
    }
}
