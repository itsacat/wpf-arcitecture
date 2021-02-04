using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralClassLibrary;

namespace WpfAppDemo.Domain
{
    class Point : Notifier
    {
        public int X
        { 
            get { return x; }
            set { 
                x = value;
                NotifyPropertyChanged("X");
            }
        }

        public int Y
        { 
            get { return y; }
            set { 
                y = value;
                NotifyPropertyChanged("Y");
            }
        }

        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }

        private int x;
        private int y;
    }
}
