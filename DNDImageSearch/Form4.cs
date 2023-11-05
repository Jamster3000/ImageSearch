using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace DNDImageSearch
{
    public partial class Form4 : Form
    {
        public SQLiteData sqliteData = new SQLiteData();
        string sourceFilePath;
        string destFolderPath = "Downloads";
        public Form4(string fileName)
        {
            InitializeComponent();
            sqliteData.openDatabase();

            var image = System.Drawing.Image.FromFile(fileName);
            largePreviewBox.Image = image;
            imagePathLabel.Text += fileName;
            sourceFilePath = fileName;


            //Get a list of keywords linked to the image
            var imageKeywords = sqliteData.getKeywords(fileName);
            keywordsLabel.Text += string.Join(", ", imageKeywords);

            //get size of the image
            string imageWidth = image.Width.ToString();
            string imageHeight = image.Height.ToString();
            sizeLabel.Text += imageWidth + " X " + imageHeight;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //(new Form3(keywords)).Show(); this.Hide();
            if (Form3.currentInstance != null)
            {
                Form3.currentInstance.Show();
                this.Hide();
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                string downloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string destFolderPath = Path.Combine(downloadFolder, "Downloads");

                if (!Directory.Exists(destFolderPath))
                {
                    Directory.CreateDirectory(destFolderPath);
                }

                string destFilePath = Path.Combine(destFolderPath, Path.GetFileName(sourceFilePath));

                File.Copy(sourceFilePath, destFilePath, true);
                successLabel.Text = "'Download' Success";
            }
            catch
            {
                successLabel.Text = "Couldn't 'Download' Image";
            }
        }

        private void downloadButton_MouseHover(object sender, EventArgs e)
        {
            downloadButton.FlatAppearance.BorderColor = Color.FromArgb(255, 28, 34, 38);
        }

        private void downloadButton_MouseLeave(object sender, EventArgs e)
        {
            downloadButton.FlatAppearance.BorderColor = Color.FromArgb(255, 209, 0, 0);
        }
    }
}
