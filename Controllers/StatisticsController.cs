﻿using BooksStore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksStore.Controllers
{
    public class StatisticsController : Controller
    {
            private readonly BooksStoreContext _context;

            public StatisticsController(BooksStoreContext context)
            {
                _context = context;
            }

            // GET: Statistics
            public IActionResult Index()
            {
                return View();
            }

            // Get gross income generated by book genres
            [HttpGet]
            public JsonResult TotalIncomeByGenre()
            {
                var result = _context.OrderDetails.Join(_context.Genres,
                    (order => order.Book.GenreId),
                    (genre => genre.GenreId),
                    (o, t) => new
                    {
                        genreID = t.GenreId,
                        genreName = t.GenreName,
                        bookPrice = o.Book.Price,
                        orderQuantity = o.Quantity
                    })
                .GroupBy(t => t.genreName)
                .Select(o => new
                {
                    Income = o.Sum(order => order.orderQuantity * order.bookPrice),
                    Name = o.Key
                });

                return Json(result);
            }

        //Get total number of items sold by book name
        [HttpGet]
        public ActionResult TotalOrdersByBook()
        {
            var result = _context.OrderDetails.Join(_context.Books,
            (order => order.Book.BookId),
            (book => book.BookId),
            (o, s) => new
            {
                bookId = s.BookId,
                bookName = s.BookName,
                orderQuantity = o.Quantity
            })
        .GroupBy(s => s.bookName)
        .Select(o => new
        {
            Amount = o.Sum(order => order.orderQuantity),
            Name = o.Key
        });

            return Json(result);
        }
    }
}
