using Enemies.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemies.Core.ViewModel
{
    public class EnemyViewModel
    {
        public string Name { get; set; }
        public UnitType Type { get; set; }
        public float Health { get; set; }
        public int Speed { get; set; }
        public int Value { get; set; }
        public float ValuePerHealth { get; set; }
    }
}
