using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2080600734_VuXuanDoanTrang_QuanLySach.Models
{
    public class Book
    {
        private int bookID;
        private string bookName;
        private string image;

        public Book(int bookID, string bookName, string image)
        {
            this.BookID = bookID;
            this.BookName = bookName;
            this.Image = image;
        }
        public Book()
        {

        }
        public int BookID { get => BookID; set => BookID = value; }
        public string BookName { get => BookName; set => BookName = value; }
        public string Image { get => Image; set => Image = value; }


    }
}