using Enemies.Core.Models;
using Enemies.Core.ViewModel;
using Enemies.Desktop.Controller;
using Enemies.Desktop.DAO;
using Enemies.Desktop.View;
using System.Windows.Forms;

namespace Enemies.Desktop
{
    public partial class EnemiesMainWindow : Form
    {
        private readonly EnemiesController controller;
        private IEnemiesDao dao;
        public EnemiesMainWindow()
        {
            InitializeComponent();

            UnitTypeComboBox.Items.AddRange(new string[] {
                "Aerial",
                "Ground"
                });
            UnitTypeComboBox.SelectedIndex = 0;

            controller = new EnemiesController(new EnemiesDao());
            dao = new EnemiesDao();

            refreshTable();
        }

        private void refreshTable()
        {
            var enemies = controller.GetAllEnemies();

            NumberOfEnemiesListedNumericUpDown.Value = enemies.Count();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = enemies;
            dataGridView1.Visible = true;
        }

        private void listEnemiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void listEnemiesByTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MovementType = UnitTypeComboBox.Text;
            int TypeNumber = 0;
            if (MovementType == "Aerial")
            {
                TypeNumber = 1 << 0;
            }
            else if (MovementType == "Ground")
            {
                TypeNumber = 1 << 1;
            }
            var enemies = controller.GetEnemiesByType(TypeNumber);
            NumberOfEnemiesListedNumericUpDown.Value = enemies.Count();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = enemies;
            dataGridView1.Visible = true;
        }

        private void listEnemiesByMinimumMaximumValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var enemies = controller.GetEnemiesByValue();
            NumberOfEnemiesListedNumericUpDown.Value = enemies.Count();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = enemies;
            dataGridView1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = (int)GreaterThanNumericUpDown.Value;
            var enemies = controller.GetEnemiesByMinimumValue(min);
            NumberOfEnemiesListedNumericUpDown.Value = enemies.Count();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = enemies;
            dataGridView1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = (int)ListEnemiesWithValueLesserThanNumericUpDown.Value;
            var enemies = controller.GetEnemiesByMaximumValue(max);
            NumberOfEnemiesListedNumericUpDown.Value = enemies.Count();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = enemies;
            dataGridView1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int min = (int)GreaterThanNumericUpDown.Value;
            int max = (int)ListEnemiesWithValueLesserThanNumericUpDown.Value;
            var enemies = controller.GetEnemiesByMinMaxValue(min,max);
            NumberOfEnemiesListedNumericUpDown.Value = enemies.Count();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = enemies;
            dataGridView1.Visible = true;
        }

        private void listEnemiesByValueHealthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var enemies = controller.GetAllEnemies();

            var viewModels = new List<EnemyViewModel>();

            foreach (var enemy in enemies)
            {
                viewModels.Add(new EnemyViewModel
                {
                    Name = enemy.Name,
                    Type = enemy.Type,
                    Health = enemy.Health,
                    Speed = enemy.Speed,
                    Value = enemy.Value,
                    ValuePerHealth = enemy.Value/enemy.Health
                });
            }
            List<EnemyViewModel> sortedByHealthPerValue = viewModels.OrderBy(o => o.ValuePerHealth).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sortedByHealthPerValue;
            dataGridView1.Visible = true;
        }

        private void addNewEnemyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new AddNewEnemyWindow(dao);
            window.ShowDialog();
            refreshTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dataGridView1.CurrentRow.DataBoundItem is Enemy enemy))
                return;

            using var addWizardForm = new AddNewEnemyWindow(dao, enemy);
            addWizardForm.ShowDialog();
            refreshTable();
        }
    }
}