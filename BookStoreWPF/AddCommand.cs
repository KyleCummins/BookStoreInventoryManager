namespace BookStoreWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Command allowing for the adding of a new book.
    /// </summary>
    public class AddCommand : CommandBase
    {
        private int nextID;

        private ModelTable model;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCommand"/> class.
        /// </summary>
        /// <param name="model">ModelTable to add the book to.</param>
        /// <param name="nextID">ID to give the new book.</param>
        public AddCommand(ModelTable model, int nextID)
        {
            this.nextID = nextID;
            this.model = model;
        }

        /// <summary>
        /// Creates a new book and adds it to the model table.
        /// </summary>
        /// <param name="parameter">Relevant parameters.</param>
        public override void Execute(object parameter)
        {
            AddWindow addWindow = new AddWindow();
            AddWindowViewModel awvm = new AddWindowViewModel();
            addWindow.DataContext = awvm;

            if (addWindow.ShowDialog() == true)
            {
                ModelBook newBook = new ModelBook(awvm.NewTitle, awvm.NewAuthor, awvm.NewISBN, awvm.NewGenre, awvm.NewDate, awvm.NewPrice, this.nextID++);
                this.model.AddBook(newBook);
            }
        }
    }
}
