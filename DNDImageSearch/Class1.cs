﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Dapper;

namespace DNDImageSearch
{
    public class SQLiteData
    {
        private SQLiteConnection conn;
        public void openDatabase()
        {
            conn = new SQLiteConnection("Data Source=imageLibrary.db");
            conn.Open();
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
                    keywords TEXT
                )");
        }

        public void insertData(string imageFile, string keywords)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Database connection is not open.");
            }

            conn.Execute("INSERT INTO Images (filename, keywords) VALUES (@Filename, @Keywords)",
            new { Filename = imageFile, Keywords = keywords });
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

        public void ClearImagesTable()
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Database connection is not open.");
            }
            conn.Execute("DELETE FROM Images");
        }
    }

    public class Image
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public string Keywords { get; set; }

        internal static System.Drawing.Bitmap FromFile(string v1, bool v2)
        {
            throw new NotImplementedException();
        }
    }
}