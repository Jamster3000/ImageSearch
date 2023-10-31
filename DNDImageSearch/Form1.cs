using System;
using System.Windows.Forms;

namespace DNDImageSearch
{
    public partial class mainWindow : Form
    {

        public SQLiteData sqlite = new SQLiteData();
        public userChosenKeywords keywords = new userChosenKeywords();
        public mainWindow()
        {
            InitializeComponent();
            //selects nothing in the text box
            querySearchBox.SelectionStart = querySearchBox.Text.Length;
            querySearchBox.SelectionLength = 0;

            sqlite.openDatabase();
            sqlite.CreateImagesTable();
        }

        private void querySearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void querySearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                keywords.keywords = querySearchBox.Text;
                (new Form3(keywords)).Show(); this.Hide();
            }
        }

        private void enterClick(object sender, EventArgs e)
        {
            keywords.keywords = querySearchBox.Text;
            (new Form3(keywords)).Show(); this.Hide();
        }

        private void querySearchBox_Enter(object sender, EventArgs e)
        {
            querySearchBox.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            (new addDataWindow()).Show(); this.Hide();
        }

        private void emptyDatabaseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all data? This includes images and keywords", "Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                sqlite.ClearImagesTable();
                MessageBox.Show("All adta removed.");
            }
        }
    }
    public class userChosenKeywords
    {
        public string keywords { get; set; }
    }
}




/*
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await MyAsyncMethod();
    }

    static async Task MyAsyncMethod()
    {
        await Task.Delay(1000); // Asynchronous operation
        Console.WriteLine("Async method complete.");
    }
}

*/