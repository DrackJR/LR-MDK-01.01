using System;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public partial class AddForm: Form
    {
        private PgUsersLoader loader_;
        public AddForm(PgUsersLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
            ApplyButton.Enabled = false;
        }

        public void AddUser()
        {
            loader_.AddUser(new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Name = NameTextBox.Text,
                Age = (int)AgeNumericUpDown.Value
            });
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            AddUser();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            AddUser();
            ApplyButton.Enabled = false;
        }

        private void AgeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }
    }
}
