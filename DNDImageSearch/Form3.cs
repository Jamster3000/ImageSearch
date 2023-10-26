using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNDImageSearch
{
    public partial class Form3 : Form
    {
        public SQLiteData sqliteData = new SQLiteData();
        public userChosenKeywords keywords;

        public Form3(userChosenKeywords keywords)
        {
            InitializeComponent();
            this.keywords = keywords;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            sqliteData.openDatabase();

            var results = sqliteData.SearchImagesByKeyword(keywords.keywords);
            if (results.Any())
            {
                int pictureX = 10;
                int pictureY = 89;
                int pictureSizeX = 220;
                int pictureSizeY = 220;
                int xRow = 1;

                foreach (var img in results)
                {
                    Console.WriteLine(img.Filename);
                    var image = System.Drawing.Image.FromFile(img.Filename);
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(pictureX, pictureY); // Set the X and Y coordinates
                    pictureBox.Size = new Size(pictureSizeX, pictureSizeY);
                    pictureBox.Image = image;

                    pictureX += 209;
                    xRow += 1;
                    if (xRow == 4)
                    {
                        xRow = 0;
                        pictureX = 10;
                        pictureY += 247;
                    }
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    Controls.Add(pictureBox);
                }
            }
            else
            {
                noImagesLabel.Visible = true;
            }
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