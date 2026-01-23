using System.Collections.Generic;
using System.Windows.Forms;

namespace ConstWinForm
{
    public partial class MainForm: Form
    {
        private List<Student> allStudent_ = new List<Student>();
        public MainForm()
        {
            InitializeComponent();
            Student s1 = new Student("Александр",18, 4.4, "0004-01");
            Student s2 = new Student("Влад", 18, 4.1, "0001-01");
            Student s3 = new Student("Никита", 17, 4.8, "0001-02");

            allStudent_.Add(s1);
            allStudent_.Add(s2);
            allStudent_.Add(s3);

            studentNameListBox.DataSource = allStudent_;

        }        
    }
}
