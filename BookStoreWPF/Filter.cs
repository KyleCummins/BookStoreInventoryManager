namespace BookStoreWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Data class representing the parameters of a filtered search.
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter"/> class.
        /// </summary>
        /// <param name="title">Title to search for.</param>
        /// <param name="author">Author to search for.</param>
        /// <param name="isbn">ISBN to search for.</param>
        /// <param name="genre">Genre to search for.</param>
        /// <param name="minDate">Earliest publishing date to be included.</param>
        /// <param name="maxDate">Latest publishing date to be included.</param>
        /// <param name="minPrice">Lowest price to be included.</param>
        /// <param name="maxPrice">Highest price to be included.</param>
        public Filter(string? title = null, string? author = null, string? isbn = null, string? genre = null, DateTime? minDate = null, DateTime? maxDate = null, decimal? minPrice = null, decimal? maxPrice = null)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.Genre = genre;
            this.MinDate = minDate;
            this.MaxDate = maxDate;
            this.MinPrice = minPrice;
            this.MaxPrice = maxPrice;
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
