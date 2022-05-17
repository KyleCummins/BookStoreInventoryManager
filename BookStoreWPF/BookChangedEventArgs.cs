namespace BookStoreWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Event arguments for updating viewmodel when model is changed.
    /// </summary>
    public class BookChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookChangedEventArgs"/> class.
        /// </summary>
        /// <param name="changedBook">Book changed.</param>
        public BookChangedEventArgs(ModelBook? changedBook = null)
        {
            this.ChangedBook = changedBook;
        }

        /// <summary>
        /// Gets or sets book which was changed.
        /// </summary>
        public ModelBook? ChangedBook { get; set; }
    }
}
