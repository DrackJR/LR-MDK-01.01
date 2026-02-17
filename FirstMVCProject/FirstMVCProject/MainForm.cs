using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using ModelViewLib.Presenters;
using ModelViewLib.Views;
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
    public partial class MainForm: Form
    {
        private UserPresenter presenter_;
        public MainForm()
        {
            InitializeComponent();
            presenter_ = new UserPresenter(new MemoryUsersModel(), MyUsersTableView);
        }

        private void RemoveToolStripButton_Click(object sender, EventArgs e)
        {
            if(
            MessageBox.Show("Вы действительно хотите удалить данного пользователя?",
                            "Внимание!",
                            MessageBoxButtons.YesNo)
            == DialogResult.Yes)

            {
                List<User> selectedUsers = MyUsersTableView.GetSelectedUsers();
                presenter_.RemoveUsers(selectedUsers);
            }
        }
    }
}
