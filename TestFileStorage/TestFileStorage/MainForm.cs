using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class LoginForm: Form
    {
        private DBUserStorage authorization_ = new DBUserStorage();
        private List<string> logins_ = new List<string>();
        public LoginForm()
        {
            InitializeComponent();
            List<User> allUsers = authorization_.Load();

            foreach(User u in allUsers)
            {
                logins_.Add(u.Login);
            }

            LoginComboBox.DataSource = logins_;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            List<User> identification = authorization_.Load();

            string login = LoginComboBox.Text;
            string password = PasswordTextBox.Text;

            if (authorization_.CheckUser(login))
            {
                MessageBox.Show("Вы в системе");
            }

            else
            {
                MessageBox.Show("Вход не удался");
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            SighUpForm signUp = new SighUpForm();
            signUp.Show();
        }
    }
}
