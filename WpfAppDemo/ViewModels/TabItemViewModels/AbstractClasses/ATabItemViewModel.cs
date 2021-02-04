using GeneralClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDemo.ViewModels.TabItemViewModels.AbstractClasses
{
    internal abstract class ATabItemViewModel : Notifier
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
