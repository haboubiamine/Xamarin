using App6.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
       

        public ItemsViewModel()
        {
            Title = "Home";
            
        }

       

        public void OnAppearing()
        {
            IsBusy = true;
           
        }

      

       

       
    }
}