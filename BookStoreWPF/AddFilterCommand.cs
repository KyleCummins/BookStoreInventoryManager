namespace BookStoreWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Command allowing for the adding of a set of filters.
    /// </summary>
    public class AddFilterCommand : CommandBase
    {
        /// <summary>
        /// ModelTable whose activeFilter should be updated.
        /// </summary>
        private ModelTable model;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFilterCommand"/> class.
        /// </summary>
        /// <param name="model">ModelTable to be filtered.</param>
        public AddFilterCommand(ModelTable model)
        {
            this.model = model;
        }

        /// <summary>
        /// Prompt the user for a new set of filters, then update the model's activeFilter.
        /// </summary>
        /// <param name="parameter">Relevant parameters.</param>
        public override void Execute(object parameter)
        {
            FilterWindow filterWindow = new FilterWindow();
            FilterWindowViewModel fwvm = new FilterWindowViewModel();
            filterWindow.DataContext = fwvm;

            if (filterWindow.ShowDialog() == true)
            {
                Filter newFilter = new Filter();

                newFilter.Title = fwvm.Title != string.Empty ? fwvm.Title : null;

                newFilter.Author = fwvm.Author != string.Empty ? fwvm.Author : null;

                newFilter.ISBN = fwvm.ISBN != string.Empty ? fwvm.ISBN : null;

                newFilter.Genre = fwvm.Genre != string.Empty ? fwvm.Genre : null;

                try
                {
                    newFilter.MinDate = DateTime.Parse(fwvm.MinDate);
                }
                catch
                {
                    newFilter.MinDate = null;
                }

                try
                {
                    newFilter.MaxDate = DateTime.Parse(fwvm.MaxDate);
                }
                catch
                {
                    newFilter.MaxDate = null;
                }

                try
                {
                    newFilter.MinPrice = decimal.Parse(fwvm.MinPrice);
                }
                catch
                {
                    try
                    {
                        newFilter.MinPrice = decimal.Parse(fwvm.MinPrice.Substring(1));
                    }
                    catch
                    {
                        newFilter.MinPrice = null;
                    }
                }

                try
                {
                    newFilter.MaxPrice = decimal.Parse(fwvm.MaxPrice);
                }
                catch
                {
                    try
                    {
                        newFilter.MaxPrice = decimal.Parse(fwvm.MaxPrice.Substring(1));
                    }
                    catch
                    {
                        newFilter.MaxPrice = null;
                    }
                }

                this.model.ActiveFilter = newFilter;
            }
        }
    }
}
