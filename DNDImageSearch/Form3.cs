using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DNDImageSearch
{
    public partial class Form3 : Form
    {
        public SQLiteData sqliteData = new SQLiteData();
        public userChosenKeywords keywords;
        public static Form3 currentInstance;

        public Form3(userChosenKeywords keywords)
        {
            InitializeComponent();
            this.keywords = keywords;
            currentInstance = this;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
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
                    //mouse hover over
                    pictureBox.MouseEnter += (s, eventAgrs) =>
                    {
                        downloadedLabel.Visible = false;
                        pictureBox.Size = new Size(pictureSizeX + 10, pictureSizeY + 10);
                    };

                    pictureBox.MouseLeave += (s, EventArgs) =>
                    {
                        downloadedLabel.Visible = false;
                        pictureBox.Size = new Size(pictureSizeX - 10, pictureSizeY - 10);
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


        private void backButton_Click(object sender, EventArgs e)
        {
            (new mainWindow()).Show(); this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}