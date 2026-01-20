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
                FileNamesListBox.SelectedIndex = FileNamesListBox.Items.Count - 1;
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
            string filePath;
            if (FileNamesListBox.SelectedItem != null)
            {
                int index = FileNamesListBox.SelectedIndex;
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "jpeg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    filePath = op.FileName;
                    FileNamesListBox.Items.Insert(index + 1, filePath);
                    FileNamesListBox.Items.RemoveAt(FileNamesListBox.SelectedIndex);
                    FileNamesListBox.SelectedIndex = FileNamesListBox.SelectedIndex + 1;
                }
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            if (FileNamesListBox.SelectedItem != null)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "jpeg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Jpeg;

                    switch (sf.FilterIndex)
                    {
                        case 1:
                            format = System.Drawing.Imaging.ImageFormat.Jpeg;
                            break;
                        case 2:
                            format = System.Drawing.Imaging.ImageFormat.Png;
                            break;
                        case 3:
                            format = System.Drawing.Imaging.ImageFormat.Bmp;
                            break;
                    }
                    PictureArea.Image.Save(sf.FileName, format);
                }
            }
        }
    }
}
