using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace Buttontest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _text;
        private bool _isEnabled;

        public string Text
        {
            get => _text;
            set
            {
                IsEnabled = !string.IsNullOrEmpty(value);
                this.RaiseAndSetIfChanged(ref _text, value);
            }
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set => this.RaiseAndSetIfChanged(ref _isEnabled, value);
        }
    }
}