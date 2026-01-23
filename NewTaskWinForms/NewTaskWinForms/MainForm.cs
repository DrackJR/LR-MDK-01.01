using System;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace NewTaskWinForms
{
    public partial class MainForm: Form
    {
        private int number_;
        private int currentSecond_;
        private int countOfTry;
        public MainForm()
        {
            InitializeComponent();
            Random r = new Random();
            number_ = r.Next(1, 101);
            Timer.Start();
            currentSecond_ = 0;
            countOfTry = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentSecond_++;
            CountdownTime.Value = new DateTime(2025, 01, 01, 0, 1, 0).AddSeconds(-currentSecond_);
            if (currentSecond_ >= 60)
            {
                Timer.Stop();
                MessageBox.Show("Время вышло, вы проиграли");
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            countOfTry++;
            if (Convert.ToInt32(InputTextBox.Text) > number_)
            {
                statisticRichTextBox.AppendText(countOfTry + " попытка, ваше число = " + InputTextBox.Text + "\n");
                MessageBox.Show("Ваше число больше загаданного");
            }
            else if (Convert.ToInt32(InputTextBox.Text) < number_)
            {
                statisticRichTextBox.AppendText(countOfTry + " попытка, ваше число = " + InputTextBox.Text + "\n");
                MessageBox.Show("Ваше число меньше загаданного");
            }
            else
            {
                Timer.Stop();
                MessageBox.Show("Вы угадали число");
                Application.Exit();
            }
        }            
    }
}
