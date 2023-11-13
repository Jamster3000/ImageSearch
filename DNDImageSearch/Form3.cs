﻿using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace imageSearch
{
    public partial class Form3 : Form
    {
        public SQLiteData sqliteData = new SQLiteData();
        public userChosenKeywords keywords;
        public static Form3 currentInstance;
        private Point previousScrollPosition = new Point(0, 0);
        string sourceFilePath;

        public Form3(userChosenKeywords keywords)
        {
            InitializeComponent();
            this.keywords = keywords;
            currentInstance = this;
        }

        private async Task test()
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
                int xRow = 0;

                foreach (var img in results)
                {
                    try
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Location = new Point(pictureX, pictureY);
                        pictureBox.BackgroundImageLayout = ImageLayout.Zoom;

                        try
                        {
                            pictureBox.Size = new Size(pictureSizeX, pictureSizeY);
                            pictureBox.BackgroundImage = System.Drawing.Image.FromFile(img.Filename);
                        }
                        catch (OutOfMemoryException)
                        {
                            pictureBox.Size = new Size(225, 225);
                            pictureBox.BorderStyle = BorderStyle.Fixed3D;
                        }


                        pictureX += pictureSizeX + 10; // Adjust for the gap between columns
                        xRow++;

                        if (xRow == 3) // Create a new row after 3 columns
                        {
                            xRow = 0;
                            pictureX = 10;
                            pictureY += pictureSizeY + 10; // Adjust for the gap between rows
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
                            previousScrollPosition = this.AutoScrollPosition;
                            string fileName = (string)((PictureBox)s).Tag;

                            (new Form4(fileName, previousScrollPosition)).Show(); this.Hide();
                        };

                        Controls.Add(pictureBox);
                    }
                    catch (FileNotFoundException)
                    { }
                }
            }
            else
            {
                noImagesLabel.Visible = true;
            }
        }
        private async void Form3_Load(object sender, EventArgs e)
        {
            await test();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            // Restore the scroll position when Form3 is activated
            this.AutoScrollPosition = new Point(-previousScrollPosition.X, -previousScrollPosition.Y);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            (new mainWindow()).Show(); this.Hide();
        }
    }
}

//TODO: Reason for OutOfMemoryError: Because some images dimentions are too big. Either refuse the image at add in, or change the size