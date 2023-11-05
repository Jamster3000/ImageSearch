using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace DNDImageSearch
{
    public partial class Form3 : Form
    {
        public SQLiteData sqliteData = new SQLiteData();
        public userChosenKeywords keywords;
        public static Form3 currentInstance;
        string sourceFilePath;
        string destFolderPath = "Downloads";

        public Form3(userChosenKeywords keywords)
        {
            InitializeComponent();
            this.keywords = keywords;
            currentInstance = this;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Button downloadButton;
            //makes sure all the images are removed from the grid as it will have to add them again, this solves the issue of repeated images
            foreach (Control control in Controls.OfType<PictureBox>().ToList())
            {
                Controls.Remove(control);
                control.Dispose();
            }

            sqliteData.openDatabase();
            var results = sqliteData.SearchImagesByKeyword(keywords.keywords);

            // if the results returned at least one image
            if (results.Any())
            {
                int pictureX = 10;
                int pictureY = 89;
                int pictureSizeX = 220;
                int pictureSizeY = 220;
                int xRow = 1;

                foreach (var img in results)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(pictureX, pictureY); // Set the X and Y coordinates
                    pictureBox.Size = new Size(pictureSizeX, pictureSizeY);//Set the X and Y size
                    pictureBox.Image = System.Drawing.Image.FromFile(img.Filename);

                    //increase x by 209 for next element in row
                    pictureX += 209;
                    xRow += 1;

                    if (xRow == 4)
                    {
                        //move onto the next column
                        xRow = 0;
                        pictureX = 10;
                        pictureY += 247;
                    }

                    PictureBox overlay = new PictureBox();

                    //Download Button
                    downloadedLabel.Visible = false;
                    sourceFilePath = img.Filename;

                    //Create download button
                    downloadButton = new Button();
                    downloadButton.Name = "download button";
                    downloadButton.Text = "⤓";
                    downloadButton.Size = new Size(40, 40);
                    downloadButton.Location = pictureBox.Location;
                    downloadButton.ForeColor = Color.White;
                    downloadButton.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);

                    Controls.Add(downloadButton);
                    downloadButton.BringToFront();

                    //download click event
                    downloadButton.Click += (t, EventArgs) =>
                    {
                        //Exactly the same code if the download button was pressed in form4
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
                    };

                    pictureBox.MouseLeave += (s, EventArgs) =>
                    {
                        downloadedLabel.Visible = false;
                    };

                    //filename
                    pictureBox.Tag = img.Filename;

                    pictureBox.Click += (s, EventArgs) =>
                    {
                        string fileName = (string)((PictureBox)s).Tag;

                        (new Form4(fileName)).Show(); this.Hide();
                    };

                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    Controls.Add(pictureBox);
                }
            }
            else
            {
                noImagesLabel.Visible = true;
            }
        }

        private void Form3_MouseEnter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            (new mainWindow()).Show(); this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}