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

            allStudent_.Add(new Student("Александр", 18, 4.4, "0004-01", "D:\\П-30 Смирнов\\jpg\\128501b704599a22c4c7fcc2214568b5.jpg"));
            allStudent_.Add(new Student("Влад", 18, 4.1, "0001-01", "D:\\П-30 Смирнов\\jpg\\pngtree-student-green-students-desk-png-image_11661274.png"));
            allStudent_.Add(new Student("Никита", 17, 4.8, "0001-02", "D:\\П-30 Смирнов\\jpg\\чувак.jpg"));


            studentNameListBox.DataSource = allStudent_;
            studentNameListBox.DisplayMember = "Name";


        }

        private void studentNameListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Student s1 = studentNameListBox.SelectedItem as Student;
            ageeLabel.Text = s1.Age.ToString();
            avgScoreLabel.Text = s1.AvgScore.ToString();
            numberIDLabel.Text = s1.NumberID;

            pictureArea.Load(s1.Photo);
            pictureArea.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
