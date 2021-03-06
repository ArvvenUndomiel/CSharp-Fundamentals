﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                if (AuthorNameCheck(value) == false)
                {
                    throw new ArgumentException("Author not valid!");

                }
                this.author = value;
                
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        private bool AuthorNameCheck(string author)
        {
            bool isValid = true;
            var names = author.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (names.Length > 1)
            {
                var secondName = names[1];

                if (char.IsDigit(secondName[0]))
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        public override string ToString()
        {
            string typeLine = $"Type: {this.GetType().Name}";
            string titleLine = $"Title: {this.Title}";
            string authorLine = $"Author: {this.Author}";
            string priceLine = $"Price: {this.Price:f2}";

            string result = string.Join(Environment.NewLine,typeLine,titleLine,authorLine,priceLine);
            return result;
        }
    }
}
