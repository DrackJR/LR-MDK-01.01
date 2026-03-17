using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TestDB
{
    public partial class MainForm: Form
    {
        PGUsersLoader postgres_ = new PGUsersLoader();
        public MainForm()
        {
            InitializeComponent();
            //var cs = "Host=192.168.1.48;Username=postgres;Password=PG@dmin$;Database=proptest";

            //var con = new NpgsqlConnection(cs);
            //con.Open();

            //var sql = "SELECT login,password FROM MyUsers";

            //var cmd = new NpgsqlCommand(sql, con);

            //var reader = cmd.ExecuteReader();
            //List<string> logins = new List<string>();
            //while (reader.Read())
            //{
            //    logins.Add(reader.GetString(0) + ":" + reader.GetString(1));
            //}
            //MessageBox.Show($"{string.Join(", ", logins)}");
            //con.Close();

            UsersDataGridView.DataSource = postgres_.Load();
        }
    }
}
