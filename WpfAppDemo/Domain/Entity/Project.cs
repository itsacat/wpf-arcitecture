using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralClassLibrary;

namespace WpfAppDemo.Domain
{
    class Project : Notifier
    {
        public List<Points> PointsList = new List<Points>();

        /*
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

        private int x;
        private int y;
        */
    }
}
