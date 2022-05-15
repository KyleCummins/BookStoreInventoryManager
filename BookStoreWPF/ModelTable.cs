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
    }
}
