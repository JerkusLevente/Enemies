using Enemies.Core.Models;
using Enemies.Desktop.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enemies.Desktop.Controller
{
    public class EnemiesController
    {
        private readonly IEnemiesDao enemiesDao;

        public EnemiesController(IEnemiesDao dao)
        {
            enemiesDao = dao;
        }

        public IEnumerable<Enemy> GetAllEnemies()
        {
            return enemiesDao.GetAllEnemies();
        }

        public IEnumerable<Enemy> GetAllEnemiesByValuePerHealth()
        {
            return enemiesDao.GetAllEnemiesByValuePerHealth();
        }

        public IEnumerable<Enemy> GetEnemiesByType(int TypeNumber)
        {
            return enemiesDao.GetEnemiesByType(TypeNumber);
        }

        public IEnumerable<Enemy> GetEnemiesByValue()
        {
            return enemiesDao.GetEnemiesByValue();
        }

        public IEnumerable<Enemy> GetEnemiesByMaximumValue(int MaximumValue)
        {
            return enemiesDao.GetEnemiesByMaximumValue(MaximumValue);
        }

        public IEnumerable<Enemy> GetEnemiesByMinimumValue(int MinimumValue)
        {
            return enemiesDao.GetEnemiesByMinimumValue(MinimumValue);
        }

        public IEnumerable<Enemy> GetEnemiesByMinMaxValue(int minVal, int maxVal)
        {
            return enemiesDao.GetEnemiesByMinMaxValue(minVal, maxVal);
        }
    }
}
