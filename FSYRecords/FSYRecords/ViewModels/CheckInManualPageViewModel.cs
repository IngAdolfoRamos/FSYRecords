using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using FSYRecords.Models;

namespace FSYRecords.ViewModels
{
    public class CheckInManualPageViewModel : BaseViewModel
    {
        public ObservableCollection<Person> People { get; }
        public CheckInManualPageViewModel()
        {
            People = new ObservableCollection<Person>();
            People.Add(new Person { Name = "Adolfo", LastName = "Ramos" });
            People.Add(new Person { Name = "Belem", LastName = "Sanchez" });
        }
    }
}
