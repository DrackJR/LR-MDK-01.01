using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace LR_PostgreSQL
{
    public class PgEventLoader
    {
        private const string connectSetting = "Host=192.168.1.48;Username=st53-6;Password=536;Database=museumdb";
        private BindingList<Event> allEvents_ = new BindingList<Event>();
        public BindingList<Event> Load()
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT venue, date, executor, cost From event";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Event museum = new Event
                    {
                        Venue = reader.GetString(0),
                        Date = reader.GetDateTime(1),
                        Executor = reader.GetString(2),
                        Cost = reader.GetInt32(3)
                    };
                    allEvents_.Add(museum);
                }
                return allEvents_;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }


        public bool DeleteSelectedUser(string venue)
        {

            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM event Where venue = @venue";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@venue", venue);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    for (int i = 0; i < allEvents_.Count; i++)
                    {
                        if (allEvents_[i].Venue == venue)
                        {
                            allEvents_.RemoveAt(i);
                            i--;
                        }
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
        public bool AddUser(Event e)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO event(venue, date, executor, cost) VALUES (@venue, @date, @executor, @cost)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@venue", e.Venue);
                cmd.Parameters.AddWithValue("@date", e.Date);
                cmd.Parameters.AddWithValue("@executor", e.Executor);
                cmd.Parameters.AddWithValue("@cost", e.Cost);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    allEvents_.Add(e);
                }
                return result;
            }

            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
        public bool EditUser(Event e)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "UPDATE event SET date = @date, executor = @executor, cost = @cost Where venue = @venue";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@venue", e.Venue);
                cmd.Parameters.AddWithValue("@date", e.Date);
                cmd.Parameters.AddWithValue("@executor", e.Executor);
                cmd.Parameters.AddWithValue("@cost", e.Cost);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    for (int i = 0; i < allEvents_.Count; i++)
                    {
                        if (allEvents_[i].Venue == e.Venue)
                        {
                            allEvents_[i] = e;
                        }
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
    }
}
