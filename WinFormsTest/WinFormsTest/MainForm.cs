using System.Windows.Forms;

namespace WinFormsTest
{
    public partial class MainForm: Form
    {        
        public MainForm()
        {
            InitializeComponent();
            //FileNamesListBox.Items.Add("Пупкин");
            //FileNamesListBox.Items.Add("Веткин");
            //FileNamesListBox.Items.Add("Креткин");
            //FileNamesListBox.Items.Add("Еткин");
        }

        private void FileNamesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //MessageBox.Show(FileNamesListBox.SelectedIndex.ToString());
            //MessageBox.Show(FileNamesListBox.SelectedItem.ToString());
            if (FileNamesListBox.SelectedItem != null)
            {
                PictureArea.Load(FileNamesListBox.SelectedItem.ToString());
                PictureArea.SizeMode = PictureBoxSizeMode.StretchImage;                
            }
        }

        private void LoadButton_Click(object sender, System.EventArgs e)
        {
            string filePath;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpeg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                filePath = op.FileName;
                FileNamesListBox.Items.Add(filePath);
            }            
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if (FileNamesListBox.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Вы уверены что хотите удалить данный файл?", "Острожно", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    FileNamesListBox.Items.RemoveAt(FileNamesListBox.SelectedIndex);
                    if (FileNamesListBox.Items.Count > 0)
                    {
                        FileNamesListBox.SelectedIndex = FileNamesListBox.Items.Count - 1;
                    }
                    else PictureArea.Image = null;
                }
            }
        }

        private void EditButton_Click(object sender, System.EventArgs e)
        {
            //string filePath;
            //if (FileNamesListBox.SelectedItem != null)
            //{
            //    OpenFileDialog op = new OpenFileDialog();
            //    op.Filter = "jpeg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp";
            //    if (op.ShowDialog() == DialogResult.OK)
            //    {
            //        filePath = op.FileName;
            //        FileNamesListBox.Items.AddRange();

            //    }
            //}
        }
    }
}
