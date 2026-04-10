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
    public partial class AddEditForm : Form
    {
        private PgEventLoader loader_;
        private bool editMode_ = false;
        public AddEditForm(PgEventLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
            ApplyButton.Enabled = false;
        }

        public void SetMuseum(Event e)
        {
            VenueTextBox.Text = e.Venue;
            VenueTextBox.Enabled = false;
            DateTextBox.Text = e.Date.ToString();
            ExecutorTextBox.Text = e.Executor;
            CostNumericUpDown.Value = e.Cost;
            editMode_ = true;
        }

        public void AddUser()
        {
            loader_.AddUser(new Event
            {
                Venue = VenueTextBox.Text,
                Date = DateTime.Parse(DateTextBox.Text),
                Executor = ExecutorTextBox.Text,
                Cost = (int)CostNumericUpDown.Value
            });
        }
        public void EditUser()
        {
            loader_.EditUser(new Event
            {
                Venue = VenueTextBox.Text,
                Date = DateTime.Parse(DateTextBox.Text),
                Executor = ExecutorTextBox.Text,
                Cost = (int)CostNumericUpDown.Value
            });
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (editMode_)
            {
                EditUser();
            }
            else
            {
                AddUser();
            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (editMode_)
            {
                EditUser();
            }
            else
            {
                AddUser();
            }
            ApplyButton.Enabled = false;
        }

        private void CostNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }

        private void ExecutorTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }

        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }

        private void VenueTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }
    }
}
