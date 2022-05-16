// <copyright file="ClearFilterCommand.cs" company="Kyle David Cummins">
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
    /// Command allowing for the current filters to be cleared.
    /// </summary>
    public class ClearFilterCommand : CommandBase
    {
        /// <summary>
        /// ModelTable whose activeFilter should be cleared.
        /// </summary>
        private ModelTable model;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearFilterCommand"/> class.
        /// </summary>
        /// <param name="model">ModelTable to be filtered.</param>
        public ClearFilterCommand(ModelTable model)
        {
            this.model = model;
        }

        /// <summary>
        /// Prompt the user for a new set of filters, then update the model's activeFilter.
        /// </summary>
        /// <param name="parameter">Relevant parameters.</param>
        public override void Execute(object parameter)
        {
            model.ActiveFilter = new Filter();
        }
    }
}
