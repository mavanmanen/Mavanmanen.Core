using System.Collections.Generic;

namespace Mavanmanen.Core.Wpf.ViewModels
{
    public class ComboBoxItemViewModel<TValue> : ViewModelBase
    {
        private string _label;
        private TValue _value;

        public string Label
        {
            get => _label;
            set
            {
                if (value == _label) return;
                _label = value;
                OnPropertyChanged();
            }
        }

        public TValue Value
        {
            get => _value;
            set
            {
                if (EqualityComparer<TValue>.Default.Equals(value, _value)) return;
                _value = value;
                OnPropertyChanged();
            }
        }
    }
}