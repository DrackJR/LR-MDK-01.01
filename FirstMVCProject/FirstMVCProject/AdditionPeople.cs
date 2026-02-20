using ModelViewLib.Models;
using ModelViewLib.ModelViews;
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
    public partial class AdditionPeople: Form
    {
        MemoryUsersModel userModel_;
        private User user_;

        public User User
        {
            set { user_ = value; }
            get { return user_; }
        }
        public AdditionPeople()
        {
            InitializeComponent();
            userModel_ = new MemoryUsersModel();            
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            List<User> allUsers = userModel_.Load();
            User = new User(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text);
            if (allUsers.Contains(User))
            {                
            }
            else
            {
                userModel_.AddUsers(User);
            }
        }
    }
}
