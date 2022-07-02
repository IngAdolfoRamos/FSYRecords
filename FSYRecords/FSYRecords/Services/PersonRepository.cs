using FSYRecords.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;

namespace FSYRecords.Services
{
    public class PersonRepository
    {
        private static SQLiteAsyncConnection _connection;

        public static async Task CreateConnection()
        {
            if (_connection != null)
            {
                return;
            }

            var documentPath = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);

            var databasePath = Path.Combine(documentPath, "FSYRecords.db");

            _connection = new SQLiteAsyncConnection(databasePath);
            await _connection.CreateTableAsync<Person>();

            Console.WriteLine("Table Person created");

            if (await _connection.Table<Person>().CountAsync() == 0)
            {
                await _connection.InsertAsync(new Person()
                {
                    Name = "Adolf",
                    LastName = "Ramos"
                });
            }
        }

        public static async Task<IEnumerable<Person>> GetPeople()
        {
            await CreateConnection();
            var people = await _connection.Table<Person>().ToListAsync();
            return people;
        }
    }
}
