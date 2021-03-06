// <copyright file="ViewBook.cs" company="Kyle David Cummins">
// Copyright (c) Kyle David Cummins. All rights reserved.
// </copyright>

namespace BookStoreWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Data class storing string representations of book properties for use in the View.
    /// </summary>
    public class ViewBook
    {
        /// <summary>
        /// Internal ID of the given book.
        /// </summary>
        private int id;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewBook"/> class.
        /// </summary>
        /// <param name="title">Title of the book.</param>
        /// <param name="author">Author of the book.</param>
        /// <param name="isbn">ISBN of the book.</param>
        /// <param name="genre">Genre of the book.</param>
        /// <param name="publishDate">Publishing date of the book.</param>
        /// <param name="price">Price of the book.</param>
        /// <param name="newID">Internal ID of the book.</param>
        public ViewBook(string title, string author, string isbn, string genre, string publishDate, string price, int newID)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.Genre = genre;
            this.Publishing_Date = publishDate;
            this.Price = price;
            this.id = newID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewBook"/> class.
        /// </summary>
        /// <param name="modelBook">ModelBook to copy values from.</param>
        public ViewBook(ModelBook modelBook)
        {
            this.Title = modelBook.Title;
            this.Author = modelBook.Author;
            this.ISBN = modelBook.ISBN;
            this.Genre = modelBook.Genre;

            this.Publishing_Date = modelBook.PublishDate.ToString("MM/dd/yyyy");
            this.Price = "$" + modelBook.Price.ToString("0.##");

            this.id = modelBook.GetID();
        }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the name of the book's author.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the ISBN of the book.
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Gets or sets the primary genre of the book.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Gets or Sets the price of the book.
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Gets or Sets the publishing date of the book.
        /// </summary>
        public string Publishing_Date { get; set; }

        /// <summary>
        /// Gets the internal ID of the book.
        /// </summary>
        /// <returns>Internal ID of the book as an int.</returns>
        public int GetID()
        {
            return this.id;
        }
    }
}
