using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            
        }

        public ICommand OpenWebCommand { get; }
    }
}