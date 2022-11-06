using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Project_Coffee_Shop_App.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            Instagram_login = new Command(async () => await Browser.OpenAsync("https://www.instagram.com/accounts/login/"));
            Facebook_login = new Command(async () => await Browser.OpenAsync("https://www.facebook.com/login/"));
        }

        public ICommand OpenWebCommand { get; }
        public ICommand Instagram_login { get; }
        public ICommand Facebook_login { get; }
    }
}