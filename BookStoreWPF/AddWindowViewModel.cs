// <copyright file="AddWindowViewModel.cs" company="Kyle David Cummins">
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
    /// ViewModel for the AddWindow.
    /// </summary>
    public class AddWindowViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddWindowViewModel"/> class.
        /// </summary>
        public AddWindowViewModel()
        {
            this.NewTitle = string.Empty;
            this.NewAuthor = string.Empty;
            this.NewISBN = string.Empty;
            this.NewGenre = string.Empty;
            this.NewDate = string.Empty;
            this.NewPrice = string.Empty;
        }

        /// <summary>
        /// Gets or sets the title of the new book.
        /// </summary>
        public string NewTitle { get; set; }

        /// <summary>
        /// Gets or sets the name of the book's new author.
        /// </summary>
        public string NewAuthor { get; set; }

        /// <summary>
        /// Gets or sets the ISBN of the new book.
        /// </summary>
        public string NewISBN { get; set; }

        /// <summary>
        /// Gets or sets the primary genre of the new book.
        /// </summary>
        public string NewGenre { get; set; }

        /// <summary>
        /// Gets or sets the publishing date of the new book.
        /// </summary>
        public string NewDate { get; set; }

        /// <summary>
        /// Gets or sets the price of the new book.
        /// </summary>
        public string NewPrice { get; set; }
    }
}
