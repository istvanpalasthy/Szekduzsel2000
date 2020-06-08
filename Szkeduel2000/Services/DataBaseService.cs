using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Szkeduel2000.Domain;

namespace Szkeduel2000.Services
{
    public class DataBaseService : IDataBaseService
    {
        
        private static readonly string _conn = Program.connectionString;
        private static NpgsqlConnection conn = new NpgsqlConnection(_conn);

        public string GetScheduleName(string email)
        {
            throw new NotImplementedException();
        }

        public List<Schedule> GetSchedules(string email)
        {
            throw new NotImplementedException();
        }
        public List<User> GetAllUser()
        {
            List<User> allUser = new List<User>();

            using (conn)
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM users", conn))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int userId = int.Parse(reader["user_id"].ToString());
                        string userEmail = reader["user_email"].ToString();
                        string nickname = reader["nickname"].ToString();
                        string password = reader["pw"].ToString();
                        User user = new User(userId,userEmail, nickname, password);
                        allUser.Add(user);
                    }

                }
            }

            return allUser;

        }

    }
}
