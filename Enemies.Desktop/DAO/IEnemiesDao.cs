using Enemies.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemies.Desktop.DAO
{
    public interface IEnemiesDao
    {
        void AddEnemy(Enemy newEnemy);
        void DeleteEnemy(int EnemyId);
        void ModifyEnemy(Enemy enemy);

        IEnumerable<Enemy> GetAllEnemies();
        IEnumerable<Enemy> GetAllEnemiesByValuePerHealth();
        IEnumerable<Enemy> GetEnemiesByType(int TypeNumber);
        IEnumerable<Enemy> GetEnemiesByValue();
        IEnumerable<Enemy> GetEnemiesByMaximumValue(int MaximumValue);
        IEnumerable<Enemy> GetEnemiesByMinimumValue(int MinimumValue);
        IEnumerable<Enemy> GetEnemiesByMinMaxValue(int minVal, int maxVal);
    }
}
