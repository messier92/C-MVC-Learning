using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfBasics2.Directory.ViewModels
{
    /// <summary>
    /// A basic command that runs an Action
    /// </summary>
    public class RelayCommand : ICommand
    {
        // The action to run
        private Action mAction;

        /// <summary>
        /// The event that's fired when the <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };


        #region Constructor
        public RelayCommand(Action action)
        {
            mAction = action;
        }

        #endregion
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the command Action
        /// </summary>
        /// <param name="parameter"></param>

        public void Execute(object parameter)
        {
            mAction();
        }
    }
}
