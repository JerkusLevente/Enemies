using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Enemies.Core.Models
{
    public class Enemy
    {
        [Key, DisplayName("Azonosító")]
        public int Id { get; set; }

        [Required, MaxLength(256), DisplayName("Enemy neve")]
        public string Name { get; set; }

        [Required, DisplayName("Enemy típusa")]
        public UnitType Type { get; set; }

        [Required, Range(1, float.MaxValue), DisplayName("Enemy életpontjai")]
        public float Health { get; set; }

        [Required, Range(1, 100), DisplayName("Enemy Sebessége")]
        public int Speed { get; set; }

        [Required, Range(1, int.MaxValue), DisplayName("Elpusztítása ennyi jutalommal jár")]
        public int Value { get; set; }

        
    }
}
