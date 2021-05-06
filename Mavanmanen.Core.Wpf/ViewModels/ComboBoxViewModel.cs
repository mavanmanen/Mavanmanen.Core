using System.Collections.ObjectModel;

namespace Mavanmanen.Core.Wpf.ViewModels
{
    public class ComboBoxViewModel<TValue>
    {
        public TValue SelectedValue { get; set; }
        public ObservableCollection<ComboBoxItemViewModel<TValue>> Items { get; set; }
    }
}