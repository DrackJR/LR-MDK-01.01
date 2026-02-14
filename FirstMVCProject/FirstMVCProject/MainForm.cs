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
        UsersTableView usersTable_ = new UsersTableView();
        public MainForm()
        {
            InitializeComponent();
            
            Controls.Add(usersTable_);
            usersTable_.Dock = DockStyle.Top;
            usersTable_.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UserPresenter presenter = new UserPresenter(new MemoryUsersModel(), usersTable_);
        }

        private void RemoveToolStripButton_Click(object sender, EventArgs e)
        {
            List<User> selectedUsers = usersTable_.GetSelectedUsers();
            
        }
    }
}
