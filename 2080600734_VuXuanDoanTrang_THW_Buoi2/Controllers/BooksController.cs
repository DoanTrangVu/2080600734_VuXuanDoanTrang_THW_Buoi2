using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _2080600734_VuXuanDoanTrang_THW_Buoi2.Models;

namespace _2080600734_VuXuanDoanTrang_THW_Buoi2.Controllers
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
        [HttpGet]
        public ActionResult Edit(int id)
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
        [HttpPost]
        public ActionResult Edit(int id, string bookname, string image)
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
                    b.BookName = bookname;
                    b.Image = image;

                }
            }
            return View("ListBook", listBook);
        }

        [HttpGet]
        public ActionResult Delete(int id)
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

        [HttpPost]
        public ActionResult Delete(int id, string bookname, string image)
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
                    listBook.Remove(b);
                    break;
                }
            }
            return View("ListBook", listBook);
        }
    }
}