// <copyright file="ModelTable.cs" company="Kyle David Cummins">
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
    /// Model class which maintains a list of books and communicates with the backend Database.
    /// </summary>
    public class ModelTable
    {
        /// <summary>
        /// Backend storage of the list of Books for querying.
        /// </summary>
        private List<ModelBook> bookList;

        /// <summary>
        /// Currently active set of search filters.
        /// </summary>
        private Filter activeFilter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTable"/> class.
        /// </summary>
        public ModelTable()
        {
            this.bookList = new List<ModelBook>();

            this.SetActiveFilter(new Filter());
        }

        /// <summary>
        /// Event handler for BookChanged event.
        /// </summary>
        /// <param name="source">Source of event.</param>
        /// <param name="args">Event args.</param>
        public delegate void BookChangedEventHandler(object source, BookChangedEventArgs args);

        /// <summary>
        /// Event signalling that a book has been changed.
        /// </summary>
        public event BookChangedEventHandler BookChanged;

        /// <summary>
        /// Updates the currently active filter.
        /// </summary>
        /// <param name="newFilter">New set of filter parameters.</param>
        public void SetActiveFilter(Filter newFilter)
        {
            this.activeFilter = newFilter;

            this.PublishBookChanged(null);
        }

        /// <summary>
        /// Retrieves the list of books matching the active search filter.
        /// </summary>
        /// <returns>List of book entries which match the provided filter.</returns>
        public List<ModelBook> GetBooks()
        {
            IEnumerable<ModelBook> filteredBooks = this.bookList;
            IEnumerable<ModelBook> oldFilteredBooks = filteredBooks;

            if (this.activeFilter.Title != null)
            {
                filteredBooks = from book in oldFilteredBooks where book.Title == this.activeFilter.Title select book;
                oldFilteredBooks = filteredBooks;
            }

            if (this.activeFilter.Author != null)
            {
                filteredBooks = from book in oldFilteredBooks where book.Author == this.activeFilter.Author select book;
                oldFilteredBooks = filteredBooks;
            }

            if (this.activeFilter.ISBN != null)
            {
                filteredBooks = (List<ModelBook>)(from book in oldFilteredBooks where book.ISBN == this.activeFilter.ISBN select book);
                oldFilteredBooks = filteredBooks;
            }

            if (this.activeFilter.Genre != null)
            {
                filteredBooks = from book in oldFilteredBooks where book.Genre == this.activeFilter.Genre select book;
                oldFilteredBooks = filteredBooks;
            }

            if (this.activeFilter.MinDate != null)
            {
                filteredBooks = from book in oldFilteredBooks where book.PublishDate >= this.activeFilter.MinDate select book;
                oldFilteredBooks = filteredBooks;
            }

            if (this.activeFilter.MaxDate != null)
            {
                filteredBooks = from book in oldFilteredBooks where book.PublishDate <= this.activeFilter.MaxDate select book;
                oldFilteredBooks = filteredBooks;
            }

            if (this.activeFilter.MinPrice != null)
            {
                filteredBooks = from book in oldFilteredBooks where book.Price >= this.activeFilter.MinPrice select book;
                oldFilteredBooks = filteredBooks;
            }

            if (this.activeFilter.Title != null)
            {
                filteredBooks = from book in oldFilteredBooks where book.Price <= this.activeFilter.MaxPrice select book;
            }

            return filteredBooks.ToList();
        }

        /// <summary>
        /// Adds a ModelBook to the list.
        /// </summary>
        /// <param name="newBook">Book to be added to list.</param>
        public void AddBook(ModelBook newBook)
        {
            this.bookList.Add(newBook);

            this.PublishBookChanged(newBook);
        }

        /// <summary>
        /// Removes the book with the given ID from the list.
        /// </summary>
        /// <param name="iD">ID of the book to be removed.</param>
        public void RemoveBook(int iD)
        {
            // TO DO: complete linq find and delete.
        }

        /// <summary>
        /// Updates the given book with new information.
        /// </summary>
        /// <param name="newBook">Book to be added to list.</param>
        public void UpdateBook(ModelBook newBook)
        {
            // TO DO: complete book updating functionality.
        }

        /// <summary>
        /// Returns the highest ID number in the current list.
        /// </summary>
        /// <returns>Highest found ID number.</returns>
        public int GetHighestID()
        {
            int max = -1;

            foreach (ModelBook book in this.bookList)
            {
                if (book.GetID() > max)
                {
                    max = book.GetID();
                }
            }

            return max;
        }

        /// <summary>
        /// Publishes BookChanged event.
        /// </summary>
        /// <param name="changedBook">Book which was changed or null.</param>
        private void PublishBookChanged(ModelBook? changedBook)
        {
            if (this.BookChanged != null)
            {
                this.BookChanged(this, new BookChangedEventArgs(changedBook));
            }
        }
    }
}
