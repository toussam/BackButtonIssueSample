using BackButtonIssueSample.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BackButtonIssueSample.ViewModels
{
    public class MasterPageMasterViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MasterPageMenuItem> MenuItems { get; set; }

        public MasterPageMasterViewModel()
        {
            MenuItems = new ObservableCollection<MasterPageMenuItem>(new[]
            {
                new MasterPageMenuItem { Id = 0, Title = "Page 1" },
                new MasterPageMenuItem { Id = 1, Title = "Page 2" },
                new MasterPageMenuItem { Id = 2, Title = "Page 3" },
                new MasterPageMenuItem { Id = 3, Title = "Page 4" },
                new MasterPageMenuItem { Id = 4, Title = "Page 5" },
             });
        }

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null) return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
