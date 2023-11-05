using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DNDImageSearch
{
    public partial class addDataWindow : Form
    {
        public SQLiteData sqliteData = new SQLiteData();
        public addDataWindow()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sqliteData.openDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiscardButton(sender, e);
        }

        private void imagePathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void imagePathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                imagePathTextBox.Text = files[0];
                imagePathTextBox.SelectionStart = imagePathTextBox.Text.Length;
            }
        }

        private void imageDialogeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose a File";
            openFileDialog.Filter = "All Files|*.*"; // Set file filter if needed

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName; // Get the selected file path
                                                               // Do something with the selected file path, e.g., display it in a textbox
                imagePathTextBox.Text = selectedFile;
                imagePathTextBox.SelectionLength = selectedFile.Length;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string imageFile = imagePathTextBox.Text;
            string userKeywords = keywordsTextBox.Text;

            if (!File.Exists(imageFile))
            {
                updateLabel.Text = "Invalid image Path";
                updateLabel.Visible = true;
            }
            else if (userKeywords == "")
            {
                updateLabel.Text = "Keyword required";
                updateLabel.Visible = true;
            }
            else
            {
                //open and write data to database
                sqliteData.openDatabase();
                sqliteData.insertData(imageFile, userKeywords);

                //inform user of success
                updateLabel.Text = "Saved Successfully!";
                updateLabel.Visible = true;

                //store the previous input for the user to see and remember
                previousImageLabel.Text = "Previous: " + imageFile;
                previousKeywordLabel.Text = "Previous: " + userKeywords;

                //Empty the textboxes
                imagePathTextBox.Text = "";
                keywordsTextBox.Text = "";
                previewBox.Image = null;

                //focus the id textbox or whatever the top input is
                imagePathTextBox.Focus();

                sqliteData.openDatabase();
                int lastId = sqliteData.lastId();
            }
        }

        private void keywordsTextBox_Enter(object sender, EventArgs e)
        {
            updateLabel.Visible = false;
        }

        private void idBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                saveButton_Click(sender, e);
            }
        }

        private void imagePathTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                saveButton_Click(sender, e);
            }
        }

        private void keywordsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                saveButton_Click(sender, e);
            }
        }

        private void DiscardButton(object sender, EventArgs e)
        {
            string imagePathText = imagePathTextBox.Text;
            string keywordsText = keywordsTextBox.Text;

            if (imagePathText == "" && keywordsText == "")
            {
                (new mainWindow()).Show(); this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Your unsaved data will be lost. Discard?", "Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    (new mainWindow()).Show(); this.Hide();
                }
            }
        }

        private void imagePathTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                previewBox.Image = System.Drawing.Image.FromFile(imagePathTextBox.Text);
            }
            catch (System.ArgumentException)
            { }
            catch (System.IO.FileNotFoundException)
            { }
        }

        private void saveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.FlatAppearance.BorderColor = Color.FromArgb(255, 209, 0, 0);
        }

        private void discardButton_MouseLeave(object sender, EventArgs e)
        {
            discardButton.FlatAppearance.BorderColor = Color.FromArgb(255, 209, 0, 0);
        }

        private void saveButton_MouseEnter(object sender, EventArgs e)
        {
            saveButton.FlatAppearance.BorderColor = Color.FromArgb(255, 28, 34, 38);
        }

        private void discardButton_MouseEnter(object sender, EventArgs e)
        {
            discardButton.FlatAppearance.BorderColor = Color.FromArgb(255, 28, 34, 38);
        }
    }
}
