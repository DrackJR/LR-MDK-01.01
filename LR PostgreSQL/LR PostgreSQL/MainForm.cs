using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_PostgreSQL
{
    public partial class MainForm : Form
    {
        private PgEventLoader loader_ = new PgEventLoader();
        public MainForm()
        {
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingList<Event> museum = loader_.Load();
            dataGridView.DataSource = museum;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            Event museum = row.DataBoundItem as Event;
            loader_.DeleteSelectedUser(museum.Venue);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            AddEditForm additionForm = new AddEditForm(loader_);
            additionForm.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            Event selectedMuseum = row.DataBoundItem as Event;
            AddEditForm addEditForm = new AddEditForm(loader_);
            addEditForm.SetMuseum(selectedMuseum);
            addEditForm.Show();
        }
    }
}
