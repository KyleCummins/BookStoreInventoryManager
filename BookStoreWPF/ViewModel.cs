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

            this.UpdateNextID();
        }

        /// <summary>
        /// Prompt the user for new book info and create book.
        /// </summary>
        private void AddBook()
        {
            AddWindow addWindow = new AddWindow();
            AddWindowViewModel awvm = new AddWindowViewModel();
            addWindow.DataContext = awvm;

            if (addWindow.ShowDialog() == true)
            {
                ModelBook newBook = new ModelBook(awvm.NewTitle, awvm.NewAuthor, awvm.NewISBN, awvm.NewGenre, awvm.NewDate, awvm.NewPrice, this.nextID++);
                this.modelTable.AddBook(newBook);
            }
        }

        /// <summary>
        /// Update the nextID field to reflect the model data.
        /// </summary>
        private void UpdateNextID()
        {
            this.nextID = this.modelTable.GetHighestID() + 1;
        }
    }
}
