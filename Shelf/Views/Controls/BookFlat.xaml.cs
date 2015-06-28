using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Shelf.Views.Controls
{
    public sealed partial class BookFlat : UserControl
    {
        public static readonly DependencyProperty BookBrushProperty =
            DependencyProperty.Register("BookBrush", typeof(Brush), typeof(BookFlat),
                new PropertyMetadata(new SolidColorBrush(Windows.UI.Color.FromArgb(255,255,255,255)), new PropertyChangedCallback(OnBookBrushChanged)));
        public Brush BookBrush
        {
            get { return (Brush)GetValue(BookBrushProperty); }
            set { SetValue(BookBrushProperty, value); }
        }
        private static void OnBookBrushChanged(DependencyObject dep, DependencyPropertyChangedEventArgs args)
        {
        }

        public static readonly DependencyProperty BookBackgroundBrushProperty =
            DependencyProperty.Register("BookBackgroundBrush", typeof(Brush), typeof(BookFlat),
        new PropertyMetadata(new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0)), new PropertyChangedCallback(OnBookBackgroundBrushChanged)));
        public Brush BookBackgroundBrush
        {
            get { return (Brush)GetValue(BookBackgroundBrushProperty); }
            set { SetValue(BookBackgroundBrushProperty, value); }
        }
        private static void OnBookBackgroundBrushChanged(DependencyObject dep, DependencyPropertyChangedEventArgs args)
        {
        }

        public BookFlat()
        {
            this.InitializeComponent();
            DataContext = this;
        }
    }
}
