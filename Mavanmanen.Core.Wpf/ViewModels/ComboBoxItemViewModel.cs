namespace Mavanmanen.Core.Wpf.ViewModels
{
    public class ComboBoxItemViewModel<TValue>
    {
        public string Label { get; set; }
        public TValue Value { get; set; }
    }
}