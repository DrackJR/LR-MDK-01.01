using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using ModelViewLib.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstMVCProject
{
    public partial class AdditionPeopleForm: Form
    {
        MemoryUsersModel userModel_;
        private User user_;
        public User User
        {
            get { return user_; }
        }
        public AdditionPeopleForm()
        {
            InitializeComponent();
            userModel_ = new MemoryUsersModel();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {            
            List<User> allUsers = userModel_.Load();
            if (LoginTextBox.Text != string.Empty && PasswordTextBox.Text != string.Empty &&
                NameTextBox.Text != string.Empty)
            {
                foreach(User u in allUsers)
                {
                    if(u.Login == LoginTextBox.Text)
                    {
                        MessageBox.Show("Такой логин уже существует");
                        return;
                    }
                }
                user_ = new User(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text);
                DialogResult = DialogResult.Yes;
                Close();
            }
            else MessageBox.Show("Вы заполнили не все данные!");
        }

    }
}
