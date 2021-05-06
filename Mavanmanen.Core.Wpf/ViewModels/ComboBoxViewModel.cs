using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mavanmanen.Core.Wpf.ViewModels
{
    public class ComboBoxViewModel<TValue> : ViewModelBase
    {
        private TValue _selectedValue;

        public TValue SelectedValue
        {
            get => _selectedValue;
            set
            {
                if (EqualityComparer<TValue>.Default.Equals(value, _selectedValue)) return;
                _selectedValue = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<ComboBoxItemViewModel<TValue>> Items { get; set; }
    }
}