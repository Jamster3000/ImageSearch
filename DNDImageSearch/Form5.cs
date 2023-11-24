using imageSearch;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DNDImageSearch
{
    public partial class Form5 : Form
    {
        public SQLiteData sqliteData = new SQLiteData();
        public userChosenKeywords keywords;
        private imageSearch.Image[] slideshowImages;
        private int index = 0;
        string sourceFilePath;
        public Form5(userChosenKeywords keywords)
        {
            InitializeComponent();
            
            this.keywords = keywords;

            sqliteData.openDatabase();

            slideshowImages = sqliteData.SearchImagesByKeyword(keywords.keywords);
            displayImage();
        }

        private void displayImage()
        {
            this.Focus();
            if (slideshowImages.Length > 0)
            {
                try
                {
                    int currentImageNumber = index + 1;
                    this.Text = slideshowImages[index].Filename + " - " + currentImageNumber.ToString() + "/" + slideshowImages.Length;// format e.g. 5/84 
                    this.BackgroundImage = System.Drawing.Image.FromFile(slideshowImages[index].Filename);
                    sourceFilePath = slideshowImages[index].Filename;
                    downloadedLabel.Visible = false;
                }
                catch (FileNotFoundException) 
                {
                    index = (index + 1) % slideshowImages.Length;
                    displayImage();
                }
                catch (OutOfMemoryException)
                {
                    index = (index + 1) % slideshowImages.Length;
                    displayImage();
                }
            }
        }
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                downloadedLabel.Visible = true;
                index = (index - 1 + slideshowImages.Length) % slideshowImages.Length;
                displayImage();
            }

            else if (e.KeyCode == Keys.Right)
            {
                downloadedLabel.Visible = true;
                index = (index + 1) % slideshowImages.Length;
                displayImage();
            }

            else if (e.KeyCode == Keys.Escape)
            {
                (new Form3(keywords)).Show(); this.Hide();
            }

            else if (e.KeyCode == Keys.D)
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
                    downloadedLabel.Text = "'Download' Success";
                    downloadedLabel.Visible = true;
                }
                catch
                {
                    downloadedLabel.Text = "Couldn't 'Download' Image";
                    downloadedLabel.Visible = true;
                }
            }
        }

        private void Form5_Click(object sender, EventArgs e)
        {
            Point point = new Point(0, 0);

            new Form4(slideshowImages[index].Filename, point).Show(); this.Hide();
        }
    }
}
