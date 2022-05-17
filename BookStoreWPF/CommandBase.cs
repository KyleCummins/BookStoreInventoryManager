namespace BookStoreWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    /// <summary>
    /// Abstract class representing base command functionality.
    /// </summary>
    public abstract class CommandBase : ICommand
    {
        /// <summary>
        /// Event signaling that CanExecute property has changed/
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Defines whether command can be executed.
        /// </summary>
        /// <param name="parameter">Relevant parameters</param>
        /// <returns>True if command can be executed, false otherwise.</returns>
        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Functionality to be executed by command.
        /// </summary>
        /// <param name="parameter">Relevant parameters.</param>
        public abstract void Execute(object parameter);

        /// <summary>
        /// Publishes CanExecuteChanged event.
        /// </summary>
        protected void OnCanExecuteChanged()
        {
            this.CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
