using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuApp.Connection
{
    public class SQL
    {
        private readonly string _connectionString;

        public SQL()
        {
            _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=Randevu;";
        }

        public DataTable ExecuteReader(string query, params NpgsqlParameter[] parameters)
        {
            DataTable resultTable = new DataTable();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        resultTable.Load(reader);
                    }
                }
            }

            return resultTable;
        }

        public int ExecuteNonQuery(string query, params NpgsqlParameter[] parameters)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();

                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
