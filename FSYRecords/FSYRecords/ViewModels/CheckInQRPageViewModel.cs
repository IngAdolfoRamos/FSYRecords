using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using ZXing;

namespace FSYRecords.ViewModels
{
    public class CheckInQRPageViewModel
    {
        public CheckInQRPageViewModel()
        {
            LogoutCommand = new Command(Logout);
            SynchCommand = new Command(Synch);
            ScanCommand = new Command(Scan);
        }

        public ICommand LogoutCommand { get; }
        public ICommand SynchCommand { get; }
        public ICommand ScanResultCommand { get; }
        public Result Result { get; set; }
        public Command ScanCommand { get; set; }

        void Scan()
        {
            var text = Result.Text;
        }

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
