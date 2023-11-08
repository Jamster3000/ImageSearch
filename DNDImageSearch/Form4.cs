using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DNDImageSearch
{
    public partial class Form4 : Form
    {
        public SQLiteData sqliteData = new SQLiteData();
        private Point previousScrollPosition;
        string sourceFilePath;
        string destFolderPath = "Downloads";
        public Form4(string fileName, Point scrollPosition)
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

            previousScrollPosition = scrollPosition;
            largePreviewBox.MouseWheel += new MouseEventHandler(largePreviewBox_MouseWheel);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //(new Form3(keywords)).Show(); this.Hide();
            if (Form3.currentInstance != null)
            {
                Form3.currentInstance.Show();
                Form3.currentInstance.AutoScrollPosition = new Point(-previousScrollPosition.X, -previousScrollPosition.Y);
                this.Hide();
            }
        }
        private void largePreviewBox_MouseWheel(object sender, MouseEventArgs e)
        {
            float zoomFactor = 1.1f; // Speed of the zoom

            // Calculate the zoom factor based on the mouse wheel delta
            if (e.Delta > 0)
            {
                // Calculate new dimensions
                int newWidth = (int)(largePreviewBox.Width * zoomFactor);
                int newHeight = (int)(largePreviewBox.Height * zoomFactor);

                // Calculate the difference between the new and old dimensions
                int widthDiff = newWidth - largePreviewBox.Width;
                int heightDiff = newHeight - largePreviewBox.Height;

                // Calculate the new location to keep the image centered
                int newX = largePreviewBox.Left - widthDiff / 2;
                int newY = largePreviewBox.Top - heightDiff / 2;

                // Update the PictureBox dimensions and location
                largePreviewBox.Size = new Size(newWidth, newHeight);
                largePreviewBox.Location = new Point(newX, newY);
            }
            else if (e.Delta < 0)
            {
                int newWidth = (int)(largePreviewBox.Width / zoomFactor);
                int newHeight = (int)(largePreviewBox.Height / zoomFactor);

                int widthDiff = largePreviewBox.Width - newWidth;
                int heightDiff = largePreviewBox.Height - newHeight;

                int newX = largePreviewBox.Left + widthDiff / 2;
                int newY = largePreviewBox.Top + heightDiff / 2;

                if (newWidth >= largePreviewBox.Parent.ClientSize.Width || newHeight >= largePreviewBox.Parent.ClientSize.Height)
                {
                    // Ensure the PictureBox doesn't become smaller than the window
                    return;
                }

                largePreviewBox.Size = new Size(newWidth, newHeight);
                largePreviewBox.Location = new Point(newX, newY);
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

        private void downloadButton_MouseLeave(object sender, EventArgs e)
        {
            downloadButton.FlatAppearance.BorderColor = Color.FromArgb(255, 209, 0, 0);
        }

        private void downloadButton_MouseEnter(object sender, EventArgs e)
        {
            downloadButton.FlatAppearance.BorderColor = Color.FromArgb(255, 28, 34, 38);
        }
    }
}


//TODO: Look at the test section and figure out what it does
//TODO: Look at analye tab
//TODO: Look at spy++
//TODO: Look at setting keyboard shortcut for window > split