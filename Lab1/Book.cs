﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Book
    {
        public const double tax = .08;
        private string book1Name;
        private string book1Author;
        private string book1ISBN;
        private decimal book1Price;

        public string author { get; set; }
        public decimal price { get; set; }
        public string ISBN { get; set; }
        public string bookName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BookName"></param>
        /// <param name="Author"></param>
        /// <param name="isbn"></param>
        /// <param name="Price"></param>
        public Book(string BookName, string Author, string isbn, decimal Price)
        {
            this.author = Author;
            this.price = Price;
            this.ISBN = isbn;
            this.bookName = BookName;
        }
        /// <summary>
        /// 
        /// </summary>
        public Book()
        {
            this.author = null;
            this.price = 0.0m;
            this.ISBN = null;
            this.bookName = null;
        }


    }

}