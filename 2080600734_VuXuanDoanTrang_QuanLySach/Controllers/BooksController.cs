using _2080600734_VuXuanDoanTrang_QuanLySach.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2080600734_VuXuanDoanTrang_QuanLySach.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult ListBook()
        {
            List<Book> listBook = new List<Book>();
            listBook.Add(new Models.Book(1, "Mỗi lần vấp ngã là một lần trưởng thành", "/Content/Book/book1.jpg"));
            listBook.Add(new Book()
            {
                BookID = 2,
                BookName = "Đừng chọn an nhàn khi còn trẻ",
                Image = "/Content/Book/book2.jpg"
            });
            return View(listBook);
        } 
        public ActionResult Details(int id)
        {
            List<Book> listBook = new List<Book>();
            listBook.Add(new Models.Book(1, "Mỗi lần vấp ngã là một lần trưởng thành", "/Content/Book/book1.jpg"));
            listBook.Add(new Book()
            {
                BookID = 2,
                BookName = "Đừng chọn an nhàn khi còn trẻ",
                Image = "/Content/Book/book2.jpg",
            });
            Book book = new Book();
            foreach(Book b in listBook)
            {
                if(b.BookID == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);  
        }
        public ActionResult EditBook(int id)
        {
            List<Book> listBook = new List<Book>();
            listBook.Add(new Models.Book(1, "Mỗi lần vấp ngã là một lần trưởng thành", "/Content/Book/book1.jpg"));
            listBook.Add(new Book()
            {
                BookID = 2,
                BookName = "Đừng chọn an nhàn khi còn trẻ",
                Image = "/Content/Book/book2.jpg",
            });
            Book book = new Book();
            foreach (Book b in listBook)
            {
                if (b.BookID == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
    }
}