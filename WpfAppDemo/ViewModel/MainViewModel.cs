using GeneralClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppDemo.ViewModels;
using WpfAppDemo.ViewModels.TabItemViewModels.AbstractClasses;
using WpfAppDemo.ViewModels.TabItemViewModels.RealizationClasses;

namespace WpfAppDemo
{
    internal class MainViewModel : Notifier
    {
        private string _name = "";
        private int _counter = 0;
        private ObservableCollection<ATabItemViewModel> _tabItemViewModels = new ObservableCollection<ATabItemViewModel>();
        private ATabItemViewModel _selecteditem = null;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        public ObservableCollection<ATabItemViewModel> TabItemViewModels
        {
            get { return _tabItemViewModels; }
            set
            {
                _tabItemViewModels = value;
                NotifyPropertyChanged(nameof(TabItemViewModels));
            }
        }


        public ATabItemViewModel SelectedItem
        {
            get { return _selecteditem; }
            set
            {
                _selecteditem = value;
                NotifyPropertyChanged(nameof(SelectedItem));
            }
        }

        public ICommand ButtonClickCommand { get; set; }

        public ICommand ButtonClick_AddTabItemViewModel_2D_Command { get; set; }

        public ICommand ButtonClick_AddTabItemViewModel_3D_Command { get; set; }

        public MainViewModel()
        {
            ButtonClickCommand = new RelayCommand(ButtonClick); 
            ButtonClick_AddTabItemViewModel_2D_Command = new RelayCommand(ButtonClick_AddTabItemViewModel_2D);
            ButtonClick_AddTabItemViewModel_3D_Command = new RelayCommand(ButtonClick_AddTabItemViewModel_3D);
        }

        private void ButtonClick(object obj)
        {
            _counter++;
            Name = Name + " " + _counter;
        }

        private void ButtonClick_AddTabItemViewModel_2D(object obj)
        {
            TabItemViewModels.Add(new TabItemViewModel_2D() { Name = "2D" });
        }

        private void ButtonClick_AddTabItemViewModel_3D(object obj)
        {
            TabItemViewModels.Add(new TabItemViewModel_3D() { Name = "3D" });
        }
    }
}
