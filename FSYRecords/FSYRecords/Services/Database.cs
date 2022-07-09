using FSYRecords.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSYRecords.Services
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>();

            //if (_database.Table<Person>().Equals == 0)
            //{
            //     _database.InsertAsync(new Person()
            //    {
            //        Name = "Adolf",
            //        LastName = "Ramos"
            //    });
            //}
        }

        public Task<List<Person>> GetPeopleAsync()
        {
            Console.WriteLine("Realizand consulta");
            return _database.Table<Person>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }

    }
}
