using System;
using System.Windows.Forms;

namespace NewTaskWinForms
{
    public partial class MainForm: Form
    {
        private int number_;
        private DateTimePicker CountdownTime2;        
        public MainForm()
        {
            InitializeComponent();
            Random r = new Random();
            number_ = r.Next(1, 101);
            Timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= 60; i++)
            {
                CountdownTime.Value = new DateTime(2025, 01, 01, 0, 1, 0).AddSeconds(-i);
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(InputTextBox.Text) > number_)
            {
                MessageBox.Show("Число больше загаданного");                
            }
            else if (Convert.ToInt32(InputTextBox.Text) < number_)
            {
                MessageBox.Show("Число меньше загаданного");
            }
            else
            {
                MessageBox.Show("Вы угадали число");
                Timer.Stop();
            }
        }
            
    }
}
