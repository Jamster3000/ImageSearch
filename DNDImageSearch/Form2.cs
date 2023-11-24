using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace imageSearch
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
                // Check if the image file already exists in the database
                Console.WriteLine(IsImageFileAlreadyInDatabase(imageFile));
                if (IsImageFileAlreadyInDatabase(imageFile))
                {
                    // Show a label to notify the user
                    updateLabel.Text = "Image already in database.";
                    updateLabel.Visible = true;
                }
                else
                {
                    //open and write data to the database
                    sqliteData.openDatabase();
                    sqliteData.insertData(imageFile, userKeywords, imageURLTextBox.Text);

                    // Inform user of success
                    updateLabel.Text = "Saved Successfully!";
                    updateLabel.Visible = true;

                    // Store the previous input for the user to see and remember
                    previousImageLabel.Text = "Previous: " + imageFile;
                    previousKeywordLabel.Text = "Previous: " + userKeywords;

                    //create now backup of database which includes added data
                    sqliteData.backup();

                    // Empty the textboxes
                    imagePathTextBox.Text = "";
                    keywordsTextBox.Text = "";
                    previewBox.Image = null;

                    //In case the saved image was too large
                    previewBox.BorderStyle = BorderStyle.None;

                    // Focus the id textbox or whatever the top input is
                    imagePathTextBox.Focus();
                }
            }
        }

        private bool IsImageFileAlreadyInDatabase(string imageFile)
        {
            // Check if the image file already exists in the database
            var existingRecord = sqliteData.SearchImagesByFilename(imageFile);

            // Return true if a record with the same image file path exists
            return existingRecord.Length > 0;
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
            catch (OutOfMemoryException)
            {
                //inform the user that the image dimensions are too big but the can continue for as long as they are okay with the image not being seen.
                DialogResult imageSizeError = MessageBox.Show("The image dimensions are too large to show an image of. You may continue but the image itself will never be shown. Continue?", "Large dimensions", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (imageSizeError == DialogResult.Yes)
                {
                    previewBox.BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    imagePathTextBox.Text = "";
                }
            }
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

        private void addDataWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void previousImageLabel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                imagePathTextBox.Text = files[0];
                imagePathTextBox.SelectionStart = imagePathTextBox.Text.Length;
            }
        }
        private void previousImageLabel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}