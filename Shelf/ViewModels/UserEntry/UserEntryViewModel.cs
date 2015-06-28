using Shelf.Commands;
using Shelf.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Shelf.ViewModels.UserEntry
{
    public class UserEntryViewModel : AbstractViewModel
    {
        private ICommand _navigateToLogin;
         
        public ICommand NavigateToLoginCommand { get { return _navigateToLogin; } } 

        public UserEntryViewModel()
        {
            _navigateToLogin = new NavigationCommand(typeof(UserLoginOAuth));
        }
    }
}
