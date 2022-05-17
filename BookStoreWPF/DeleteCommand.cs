// <copyright file="DeleteCommand.cs" company="Kyle David Cummins">
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
    /// Command allowing for the removal of a book from the table.
    /// </summary>
    public class DeleteCommand : CommandBase
    {
        private ModelTable model;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCommand"/> class.
        /// </summary>
        /// <param name="model">ModelTable to add the book to.</param>
        /// <param name="nextID">ID to give the new book.</param>
        public DeleteCommand(ModelTable model)
        {
            this.model = model;
        }

        /// <summary>
        /// Creates a new book and adds it to the model table.
        /// </summary>
        /// <param name="parameter">Relevant parameters.</param>
        public override void Execute(object parameter)
        {
            ViewBook toRemove = (ViewBook)parameter;

            this.model.RemoveBook(toRemove.GetID());
        }
    }
}
