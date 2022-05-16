// <copyright file="ViewModel.cs" company="Kyle David Cummins">
// Copyright (c) Kyle David Cummins. All rights reserved.
// </copyright>

namespace BookStoreWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    /// <summary>
    /// Handles passing data to and from the View and Model.
    /// </summary>
    public class ViewModel
    {
        /// <summary>
        /// Next ID to assign to newly created books.
        /// </summary>
        private int nextID = 0;

        /// <summary>
        /// Gets or sets book list to be displayed to main window.
        /// </summary>
        public List<ViewBook> ViewTable { get; set; }

        /// <summary>
        /// Model serving as the backend data storage.
        /// </summary>
        private ModelTable modelTable;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            this.ViewTable = new List<ViewBook>();

            this.modelTable = new ModelTable();

            // Test Binding
            this.ViewTable.Add(new ViewBook("Book1", "Me Myself", "000-0-00-000000-0", "Fiction", DateTime.Now.Date.ToString("MM/dd/yyyy"), "$9.99", 0));
            this.ViewTable.Add(new ViewBook("Book1", "Me Myself", "000-0-00-000000-0", "Fiction", DateTime.Now.Date.ToString("MM/dd/yyyy"), "$9.99", 0));
            this.ViewTable.Add(new ViewBook("Book1", "Me Myself", "000-0-00-000000-0", "Fiction", DateTime.Now.Date.ToString("MM/dd/yyyy"), "$9.99", 0));

            // Organize necessary events here
            this.modelTable.BookChanged += this.OnBookChanged;

            this.UpdateNextID();

            this.AddBook = new AddCommand(this.modelTable, this.nextID);
        }

        /// <summary>
        /// Subscriber to the model's BookChanged event.
        /// </summary>
        /// <param name="source">Source object of event.</param>
        /// <param name="args">Event args containing changed book.</param>
        public void OnBookChanged(object source, BookChangedEventArgs args)
        {
            int changedID = args.ChangedBook.GetID();

            // Check if book is in current list.
            int index = this.ViewTable.FindIndex(b => b.GetID() == changedID);
            if (index >= 0)
            {
                // Book already exists, delete from view before adding.
                this.ViewTable.RemoveAt(index);
            }

            this.ViewTable.Add(new ViewBook(args.ChangedBook));
        }

        /// <summary>
        /// Gets a command to prompt the user for new book info and create book.
        /// </summary>
        public ICommand AddBook { get; }

        /// <summary>
        /// Gets a command that removes the selected book from the list.
        /// </summary>
        public ICommand RemoveBook { get; }

        /// <summary>
        /// Gets a command that creates a new filter for displaying books.
        /// </summary>
        public ICommand AddFilter { get; }

        /// <summary>
        /// Gets a command that removes any applied filters.
        /// </summary>
        public ICommand ClearFilter { get; }

        /// <summary>
        /// Update the nextID field to reflect the model data.
        /// </summary>
        private void UpdateNextID()
        {
            this.nextID = this.modelTable.GetHighestID() + 1;
        }
    }
}
