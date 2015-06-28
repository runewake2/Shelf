using Shelf.Models.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace Shelf.Commands
{
    public class NavigationCommand : ICommand
    {
        private Type _navigateTo;

        public event EventHandler CanExecuteChanged;

        public NavigationCommand(Type navigateTo)
        {
            _navigateTo = navigateTo;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            NavigationHandler.NavigateTo(_navigateTo);
        }
    }
}
