using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Shelf.Models.Navigation
{
    public static class NavigationHandler
    {
        private static Frame _navigationFrame;

        public static void RegisterFrame(Frame frame)
        {
            _navigationFrame = frame;
        }

        public static void NavigateTo(Type page)
        {
            _navigationFrame.Navigate(page, null, new Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionInfo());
        }

        public static void NavigateBack()
        {
            if (_navigationFrame.CanGoBack)
            {
                _navigationFrame.GoBack();
            }
        }
    }
}
