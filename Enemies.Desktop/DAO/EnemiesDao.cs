using Enemies.Core.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemies.Desktop.DAO
{


    public class EnemiesDao : IEnemiesDao
    {
        private const string Connection_String = @"Data Source=C:\Enemies\Enemies.Web\DB\Enemies.db;";
        private bool isValue = false;

        public void AddEnemy(Enemy newEnemy)
        {
            using SQLiteConnection connection = new SQLiteConnection(Connection_String);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();

            command.CommandText = "INSERT INTO enemies "
                + "(Name, Type , Health , Speed, Value) values "
                + "(@Name, @Type , @Health , @Speed, @Value);";

            command.Parameters.Add("Name", System.Data.DbType.String).Value = newEnemy.Name;
            command.Parameters.Add("Type", System.Data.DbType.Int32).Value = newEnemy.Type;
            command.Parameters.Add("Health", System.Data.DbType.Double).Value = newEnemy.Health;
            command.Parameters.Add("Speed", System.Data.DbType.Int32).Value = newEnemy.Speed;
            command.Parameters.Add("Value", System.Data.DbType.Int32).Value = newEnemy.Value;

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteEnemy(int EnemyId)
        {
            using SQLiteConnection connection = new SQLiteConnection(Connection_String);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM enemies WHERE ID=@ID;";

            command.Parameters.Add("ID", System.Data.DbType.Int32).Value = EnemyId;

            command.ExecuteNonQuery();

            connection.Close();
        }

        public IEnumerable<Enemy> GetAllEnemies()
        {
            List<Enemy> enemies = new List<Enemy>();

            using SQLiteConnection connection = new SQLiteConnection(Connection_String);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM enemies";

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {

                enemies.Add(new Enemy
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Type = (UnitType)reader.GetInt32(reader.GetOrdinal("Type")),
                    Health = reader.GetFloat(reader.GetOrdinal("Health")),
                    Speed = reader.GetInt32(reader.GetOrdinal("Speed")),
                    Value = reader.GetInt32(reader.GetOrdinal("Value")),
                });
            }
            connection.Close();
            return enemies;
        }

        public IEnumerable<Enemy> GetAllEnemiesByValuePerHealth()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Enemy> GetEnemiesByMaximumValue(int MaximumValue)
        {
            List<Enemy> enemies = new List<Enemy>();

            using SQLiteConnection connection = new SQLiteConnection(Connection_String);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM enemies WHERE Value  <= @MaximumValue";
            command.Parameters.AddWithValue("@MaximumValue", MaximumValue);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {

                enemies.Add(new Enemy
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Type = (UnitType)reader.GetInt32(reader.GetOrdinal("Type")),
                    Health = reader.GetFloat(reader.GetOrdinal("Health")),
                    Speed = reader.GetInt32(reader.GetOrdinal("Speed")),
                    Value = reader.GetInt32(reader.GetOrdinal("Value")),
                });
            }
            connection.Close();
            return enemies;
        }

        public IEnumerable<Enemy> GetEnemiesByMinimumValue(int MinimumValue)
        {
            List<Enemy> enemies = new List<Enemy>();

            using SQLiteConnection connection = new SQLiteConnection(Connection_String);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM enemies WHERE Value  >= @MinimumValue";
            command.Parameters.AddWithValue("@MinimumValue", MinimumValue);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {

                enemies.Add(new Enemy
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Type = (UnitType)reader.GetInt32(reader.GetOrdinal("Type")),
                    Health = reader.GetFloat(reader.GetOrdinal("Health")),
                    Speed = reader.GetInt32(reader.GetOrdinal("Speed")),
                    Value = reader.GetInt32(reader.GetOrdinal("Value")),
                });
            }
            connection.Close();
            return enemies;
        }

        public IEnumerable<Enemy> GetEnemiesByMinMaxValue(int minVal, int maxVal)
        {
            List<Enemy> enemies = new List<Enemy>();

            using SQLiteConnection connection = new SQLiteConnection(Connection_String);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM enemies WHERE Value  >= @MinimumValue AND Value  <= @MaximumValue";
            command.Parameters.AddWithValue("@MinimumValue", minVal);
            command.Parameters.AddWithValue("@MaximumValue", maxVal);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {

                enemies.Add(new Enemy
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Type = (UnitType)reader.GetInt32(reader.GetOrdinal("Type")),
                    Health = reader.GetFloat(reader.GetOrdinal("Health")),
                    Speed = reader.GetInt32(reader.GetOrdinal("Speed")),
                    Value = reader.GetInt32(reader.GetOrdinal("Value")),
                });
            }
            connection.Close();
            return enemies;
        }

        public IEnumerable<Enemy> GetEnemiesByType(int TypeNumber)
        {
            List<Enemy> enemies = new List<Enemy>();

            using SQLiteConnection connection = new SQLiteConnection(Connection_String);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM enemies WHERE Type  = @Type";
            command.Parameters.AddWithValue("@Type", TypeNumber);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {

                enemies.Add(new Enemy
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Type = (UnitType)reader.GetInt32(reader.GetOrdinal("Type")),
                    Health = reader.GetFloat(reader.GetOrdinal("Health")),
                    Speed = reader.GetInt32(reader.GetOrdinal("Speed")),
                    Value = reader.GetInt32(reader.GetOrdinal("Value")),
                });
            }
            connection.Close();
            return enemies;
        }

        public IEnumerable<Enemy> GetEnemiesByValue()
        {
            List<Enemy> enemies = new List<Enemy>();

            using SQLiteConnection connection = new SQLiteConnection(Connection_String);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            if (isValue)
            {
                command.CommandText = "SELECT * FROM enemies ORDER BY Value DESC";
            }
            else
            {
                command.CommandText = "SELECT * FROM enemies ORDER BY Value ASC";
            }

            isValue = !isValue;

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {

                enemies.Add(new Enemy
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Type = (UnitType)reader.GetInt32(reader.GetOrdinal("Type")),
                    Health = reader.GetFloat(reader.GetOrdinal("Health")),
                    Speed = reader.GetInt32(reader.GetOrdinal("Speed")),
                    Value = reader.GetInt32(reader.GetOrdinal("Value")),
                });
            }
            connection.Close();
            return enemies;
        }

        public void ModifyEnemy(Enemy enemy)
        {
            using SQLiteConnection connection = new SQLiteConnection(Connection_String);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE enemies SET "
                + "Name=@Name, Type=@Type, Health=@Health, Speed=@Speed, Value=@Value "
                + "where ID=@ID;";

            command.Parameters.Add("Name", System.Data.DbType.String).Value = enemy.Name;
            command.Parameters.Add("Type", System.Data.DbType.Int32).Value = enemy.Type;
            command.Parameters.Add("Health", System.Data.DbType.Double).Value = enemy.Health;
            command.Parameters.Add("Speed", System.Data.DbType.Int32).Value = enemy.Speed;
            command.Parameters.Add("Value", System.Data.DbType.Int32).Value = enemy.Value;
            command.Parameters.Add("ID", System.Data.DbType.Int32).Value = enemy.Id;

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
