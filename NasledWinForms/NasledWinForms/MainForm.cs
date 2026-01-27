using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NasledWinForms
{
    public partial class MainForm: Form
    {
        private List<HomoSapiens> allPeople_ = new List<HomoSapiens>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            allPeople_.Add(new HomoSapiens("Никита Андрианов", 18));
            allPeople_.Add(new HomoSapiens("Владислав Смирнов", 10));
            allPeople_.Add(new Student(1001));

            foreach(HomoSapiens people in allPeople_)
            {
                HomoSapiensInfoRichTextBox.AppendText(people.ToString() + "\n");
            }

            StudentsInfoRichTextBox.Text = string.Join(",", AllStudentInfo());
        }

        public List<string> AllStudentInfo()
        {
            List<string> result = new List<string>();

            foreach(HomoSapiens people in allPeople_)
            {
                Student st = people as Student;

                if (st != null)
                {
                    result.Add(st.ToString());
                }
            }
            return result;
        }
    }
}
