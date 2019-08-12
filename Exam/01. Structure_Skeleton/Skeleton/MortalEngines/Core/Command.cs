using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MortalEngines.Core
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ;
        }
    }
}
