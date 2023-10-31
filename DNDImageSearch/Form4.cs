using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DNDImageSearch
{
    public partial class Form4 : Form
    {
        public SQLiteData sqliteData = new SQLiteData();
        public Form4(string fileName)
        {
            InitializeComponent();
            sqliteData.openDatabase();

            largePreviewBox.Image = System.Drawing.Image.FromFile(fileName);
            imagePathLabel.Text += fileName;

            var imageKeywords = sqliteData.getKeywords(fileName);

            keywordsLabel.Text += string.Join(", ", imageKeywords);
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
    }
}
