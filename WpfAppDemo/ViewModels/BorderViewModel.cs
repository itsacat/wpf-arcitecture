using GeneralClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDemo
{
    internal class BorderViewModel : Notifier
    { 
        private string _name = "";

        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }
    }
}
