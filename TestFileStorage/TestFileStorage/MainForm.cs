using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class LoginForm: Form
    {
        private FileUserStorage authorization = new FileUserStorage();
        private List<string> logins = new List<string>();
        public LoginForm()
        {
            InitializeComponent();
            List<User> allUsers = new List<User>();
            allUsers = authorization.Load();

            foreach(User u in allUsers)
            {
                logins.Add(u.Login);
            }

            LoginComboBox.DataSource = logins;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            List<User> identification = authorization.Load();

            string login = LoginComboBox.Text;
            string password = PasswordTextBox.Text;

            if (authorization.Authorize(login,password))
            {
                MessageBox.Show("Вы в системе");
            }

            else
            {
                MessageBox.Show("Вход не удался");
            }
        }
    }
}
