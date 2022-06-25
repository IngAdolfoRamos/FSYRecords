using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FSYRecords.ViewModels
{
    public class CheckInQRPageViewModel
    {
        public CheckInQRPageViewModel()
        {
            LogoutCommand = new Command(Logout);
            SynchCommand = new Command(Synch);
        }

        public ICommand LogoutCommand { get; }
        public ICommand SynchCommand { get; }

        async void Synch()
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", "Sincronizando datos... por favor espera", "Reintentar","Cancelar");
        }
        async void Logout()
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
