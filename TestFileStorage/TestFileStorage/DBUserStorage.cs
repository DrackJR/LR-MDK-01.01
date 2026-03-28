using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestFileStorage
{
    public class DBUserStorage : IUserInterface
    {
        private const string connectSetting = "Host=192.168.1.48;Username=st50-6;Password=506;Database=Test";
        private List<User> allUsers_ = new List<User>();
        public List<User> Load()
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login, password From quarty";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User(reader.GetString(0), reader.GetString(1));
                    allUsers_.Add(user);
                }
                return allUsers_;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }

        public bool CheckUser(string log)
        {            
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "Select exists(select 1 from quarty where login = @login)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", log);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetBoolean(0))
                    {
                        result = true;
                    }
                }
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }

        public bool Registration(User u)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO quarty(login, password) VALUES (@login, @password)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", u.Login);
                cmd.Parameters.AddWithValue("@password", u.Password);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    allUsers_.Add(u);
                }
                return result;
            }

            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }        
    }
}
