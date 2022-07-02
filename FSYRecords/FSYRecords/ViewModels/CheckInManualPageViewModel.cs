using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using FSYRecords.Models;
using FSYRecords.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace FSYRecords.ViewModels
{
    public class CheckInManualPageViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Person> Person { get; }
        public AsyncCommand RefreshCommand { get; }
        public CheckInManualPageViewModel()
        {
            Person = new ObservableRangeCollection<Person>();

            RefreshCommand = new AsyncCommand(Refresh);

            var people = PersonRepository.GetPeople();
            Person.AddRange(people);

            //var people = PersonRepository.GetPeople();
            //Person.AddRange((IEnumerable<Person>)people);
            //People.Add(new Person { Name = "Adolfo", LastName = "Ramos" });
            //People.Add(new Person { Name = "Belem", LastName = "Sanchez" });
        }

        async Task Refresh()
        {
            //var people = await PersonRepository.GetPeople();
            //Person.AddRange(people);
        }
    }
}
