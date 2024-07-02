using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Lab_4
{
    public static class DatabaseHelper
    {
        private const string ConnectionString = "Data Source=cosmetics.db;Version=3;";

        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Cosmetics (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Type TEXT NOT NULL,
                                            Brand TEXT NOT NULL,
                                            Manufacturer TEXT NOT NULL,
                                            ExpiryDate TEXT NOT NULL,
                                            Price REAL NOT NULL)";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddCosmetic(Cosmetic cosmetic)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = @"INSERT INTO Cosmetics (Type, Brand, Manufacturer, ExpiryDate, Price)
                                       VALUES (@Type, @Brand, @Manufacturer, @ExpiryDate, @Price)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Type", cosmetic.Type);
                    command.Parameters.AddWithValue("@Brand", cosmetic.Brand);
                    command.Parameters.AddWithValue("@Manufacturer", cosmetic.Manufacturer);
                    command.Parameters.AddWithValue("@ExpiryDate", cosmetic.ExpiryDate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Price", cosmetic.Price);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteCosmetic(Cosmetic cosmetic)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string deleteQuery = @"DELETE FROM Cosmetics WHERE Type = @Type AND Brand = @Brand AND Manufacturer = @Manufacturer AND ExpiryDate = @ExpiryDate AND Price = @Price";
                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Type", cosmetic.Type);
                    command.Parameters.AddWithValue("@Brand", cosmetic.Brand);
                    command.Parameters.AddWithValue("@Manufacturer", cosmetic.Manufacturer);
                    command.Parameters.AddWithValue("@ExpiryDate", cosmetic.ExpiryDate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Price", cosmetic.Price);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Cosmetic> GetCosmetics()
        {
            var cosmetics = new List<Cosmetic>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Cosmetics";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cosmetic = new Cosmetic
                            {
                                Type = reader["Type"].ToString(),
                                Brand = reader["Brand"].ToString(),
                                Manufacturer = reader["Manufacturer"].ToString(),
                                ExpiryDate = DateTime.Parse(reader["ExpiryDate"].ToString()),
                                Price = Convert.ToDecimal(reader["Price"])
                            };
                            cosmetics.Add(cosmetic);
                        }
                    }
                }
            }

            return cosmetics;
        }
    }
}
