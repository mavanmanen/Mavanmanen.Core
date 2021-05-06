using System;
using System.Windows;
using Mavanmanen.Core.Wpf.ViewModels;

namespace Mavanmanen.Core.Wpf.Annotations.Windows
{
    public class WindowBase<TViewModel> : Window where TViewModel : ViewModelBase, new()
    {
        protected TViewModel ViewModel
        {
            get => (TViewModel) DataContext;
            set => DataContext = value;
        }

        protected override void OnInitialized(EventArgs e)
        {
            ViewModel = new TViewModel();
            base.OnInitialized(e);
        }
    }
}