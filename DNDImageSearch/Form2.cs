using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            //TODO: Get the last id in the database and set that as default id adding 1 to the number
            sqliteData.openDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new mainWindow()).Show(); this.Hide();
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
        {//TODO: Need to clear the three inputs when data saved
         //TODO: Need to have a label to remember what the last set of keywords and id was.
         //TODO: Actull save the ID and allow the user to change it. This would mean that it needs to read the last ID saved and add one nuumber to it.
         //TODO: Get the RGB colours from dndbeyond and work with that into the design of the app
            string id = idBox.Text;
            string imageFile = imagePathTextBox.Text;
            string userKeywords = keywordsTextBox.Text;
            Console.WriteLine(userKeywords);
            if (id == "" ^ id == " ")
            {
                updateLabel.Text = "valid image ID Required";
                updateLabel.Visible = true;
            }
            else if (!File.Exists(imageFile))
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

                //
                idBox.Text = "";
                imagePathTextBox.Text = "";
                keywordsTextBox.Text = "";
            }
        }

        private void idBox_Enter(object sender, EventArgs e)
        {
            updateLabel.Visible = false;
        }

        private void imagePathTextBox_Enter(object sender, EventArgs e)
        {
            updateLabel.Visible = false;
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
            DialogResult result = MessageBox.Show("Your unsaved data will be lost. Discard?", "Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes) 
            {
                button1_Click(sender, e);
            }
        }
    }
}
