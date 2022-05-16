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

        private List<ViewBook> viewTable;

        /// <summary>
        /// Model serving as the backend data storage.
        /// </summary>
        private ModelTable modelTable;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            this.viewTable = new List<ViewBook>();

            this.modelTable = new ModelTable();

            // Organize necessary events here

            this.UpdateNextID();
        }

        /// <summary>
        /// Prompt the user for new book info and create book.
        /// </summary>
        public void AddBook()
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
