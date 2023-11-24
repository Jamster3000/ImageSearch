using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace imageSearch
{
    public class SQLiteData
    {
        private SQLiteConnection conn;
        public void openDatabase()
        {
            //check if the imageLibrary file is exists if not then try to check for backup if exists make that the imageLIbrary file and create a backup fo that
            if (!File.Exists("imageLibrary.db"))
            {
                if (File.Exists("imageLibraryBackup.db"))
                {
                    //copy and rename backup database making that the official main database
                    File.Copy("imageLibraryBackup.db", "imageLibrary.db");
                }
                else
                {
                    //this already assumes that the imageLibrary.db file dosen't exist
                    //and assuming the imageLibraryBackup doesn't exists
                    SQLiteConnection.CreateFile("imageLibrary.db");
                    MessageBox.Show("The database was missing or couldn't be found.\nNew empty database was created.", "Missing database");
                }
            }

            conn = new SQLiteConnection("Data Source=imageLibrary.db");
            conn.Open();
            backup();
        }

        public void CreateImagesTable()
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Database connection is not open.");
            }
            conn.Execute(@"
                CREATE TABLE IF NOT EXISTS Images (
                    id INTEGER PRIMARY KEY,
                    filename TEXT,
                    keywords TEXT,
                    imageURL TEXT
                )");
        }
        
        public (List<string> keywords, string imageURL) getKeywords(string imagePath)
        {
            List<string> keywords = new List<string>();
            string imageURL = "";

            string query = "SELECT Keywords, ImageURL FROM Images WHERE Filename = @Filename";

            using (SQLiteCommand command = new SQLiteCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Filename", imagePath);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string keywordsString = reader["Keywords"].ToString();
                        imageURL = reader["ImageURL"].ToString();

                        string[] imageKeywords = keywordsString.Split(',');

                        foreach (string keyword in imageKeywords)
                        {
                            keywords.Add(keyword.Trim());
                        }
                    }
                }
            }

            return (keywords, imageURL);
        }

        public void UpdateImageURL(string filename, string newImageURL)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Database connection is not open.");
            }

            string query = "UPDATE Images SET imageURL = @NewImageURL WHERE filename = @Filename";

            conn.Execute(query, new { NewImageURL = newImageURL, Filename = filename });
        }


        public void insertData(string imageFile, string keywords, string imageURL)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Database connection is not open.");
            }

            conn.Execute("INSERT INTO Images (filename, keywords, imageURL) VALUES (@Filename, @Keywords, @ImageURL)",
                new { Filename = imageFile, Keywords = keywords, ImageURL = imageURL });
        }


        public Image[] SearchImagesByKeyword(string keyword)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Database connection is not open.");
            }


            return conn.Query<Image>(
                "SELECT * FROM Images WHERE keywords LIKE @Keyword",
                new { Keyword = "%" + keyword + "%" }).ToArray();
        }

        public Image[] SearchImagesByFilename(string filename)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Database connection is not open.");
            }

            return conn.Query<Image>(
                "SELECT * FROM Images WHERE filename = @Filename",
                new { Filename = filename }).ToArray();
        }


        public void ClearImagesTable()
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Database connection is not open.");
            }
            conn.Execute("DELETE FROM Images");
        }

        public void backup()
        {
            using (var location = new SQLiteConnection(@"Data Source=imageLibrary.db; Version=3;"))
            using (var destination = new SQLiteConnection(@"Data Source=imageLibraryBackup.db; Version=3;"))
            {
                try
                {
                    location.Open();
                    destination.Open();
                    location.BackupDatabase(destination, "main", "main", -1, null, 0);
                }
                catch (System.Data.SQLite.SQLiteException) { }
            }
        }
    }

    public class Image
    {
        public string Filename { get; set; }
        public string ImageURL { get; set; }

    }
}