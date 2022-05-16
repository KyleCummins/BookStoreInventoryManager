// <copyright file="FilterWindowViewModel.cs" company="Kyle David Cummins">
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
    /// ViewModel for the FilterWindow.
    /// </summary>
    public class FilterWindowViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterWindowViewModel"/> class.
        /// </summary>
        public FilterWindowViewModel()
        {
            this.Title = null;
            this.Author = null;
            this.ISBN = null;
            this.Genre = null;
            this.MinDate = null;
            this.MaxDate = null;
            this.MinPrice = null;
            this.MaxPrice = null;
        }

        /// <summary>
        /// Gets or sets the title to search for.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the author to search for.
        /// </summary>
        public string? Author { get; set; }

        /// <summary>
        /// Gets or sets the ISBN to search for.
        /// </summary>
        public string? ISBN { get; set; }

        /// <summary>
        /// Gets or sets the primary genre to search for.
        /// </summary>
        public string? Genre { get; set; }

        /// <summary>
        /// Gets or Sets the minimum price to be included in the search.
        /// </summary>
        public decimal? MinPrice { get; set; }

        /// <summary>
        /// Gets or Sets the maximum price to be included in the search.
        /// </summary>
        public decimal? MaxPrice { get; set; }

        /// <summary>
        /// Gets or Sets the earliest publishing date to be included in the search.
        /// </summary>
        public DateTime? MinDate { get; set; }

        /// <summary>
        /// Gets or Sets the latest publishing date to be included in the search.
        /// </summary>
        public DateTime? MaxDate { get; set; }
    }
}