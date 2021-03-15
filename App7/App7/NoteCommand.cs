using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App7
{
    class NoteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;


        Action<object> action;
        public NoteCommand(Action<object> action)
        {
            this.action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action(parameter);
        }
    }
}
