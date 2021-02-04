using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppDemo.Controls
{
    internal class CustomBorder : Border
    {
        public CustomBorder()
        {
            BorderViewModel borderViewModel1 = new BorderViewModel();
            borderViewModel1.Name = BaseName + " " + nameof(BorderViewModel);
        }


        public static readonly DependencyProperty BaseNameProperty = DependencyProperty.Register(
            nameof(BaseName),
            typeof(string),
            typeof(CustomBorder),
            new UIPropertyMetadata("", PropertyChangedCallback_Name),
            ValidateValueCallback_Name);

        // Оболочка CLR, реализованная унаследованными
        // методами GetValue()/SetValue().
        public string BaseName
        {
            get { return (string)GetValue(BaseNameProperty); }
            set { base.SetValue(BaseNameProperty, value); }
        }

        private static void PropertyChangedCallback_Name(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is CustomBorder customBorder)
            {
                if (e.NewValue != null)
                {
                    if (e.NewValue is string name)
                    {
                        if (customBorder.DataContext is BorderViewModel borderViewModel)
                            borderViewModel.Name = name + " " + nameof(BorderViewModel);
                        else
                        {
                            BorderViewModel borderViewModel1 = new BorderViewModel();
                            borderViewModel1.Name = name + " " + nameof(BorderViewModel);
                            customBorder.DataContext = borderViewModel1;
                        }
                    }
                }
            }
        }

        private static bool ValidateValueCallback_Name(object value)
        {
            return true;
        }
    }
}
