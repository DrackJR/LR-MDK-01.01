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
    public partial class AdditionPeople: Form
    {
        private User user_;
        private IUsersModel usersModel_;
        public AdditionPeople(IUsersModel model)
        {
            InitializeComponent();
            usersModel_ = model;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            user_ = new User(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text);
            bool result = usersModel_.AddUsers(user_);
            if (result)
            {
                MessageBox.Show("Пользователь успешно добавлен!", "Успех",
                    MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует!", "Ошибка",
                    MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
