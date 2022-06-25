using FSYRecords.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FSYRecords.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckInQRPage : ContentPage
    {
        public CheckInQRPage()
        {
            InitializeComponent();
            BindingContext = new CheckInQRPageViewModel();
        }
    }
}