using FSYRecords.Models;
using FSYRecords.ViewModels;
using MvvmHelpers;
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
    public partial class CheckInManualPage : ContentPage
    {

        public ObservableRangeCollection<Person> Person { get; }
        public CheckInManualPage()
        {
            InitializeComponent();
            //Person = new ObservableRangeCollection<Person>()
            //{
            //    Name = "Adolf",
            //});
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            Console.WriteLine("Consultando datos");
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            Console.WriteLine("Datos mostrados");
        }
    }
}