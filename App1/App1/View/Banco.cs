using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace App1.View
{
    public class Banco
    {
        public class DatabaseContext
        {
            public interface IDatabasePath
            {
                string GetDatabasePath();
            }

            private SQLiteConnection _connection;

            public DatabaseContext(string databasePath)
            {
                _connection = new SQLiteConnection(databasePath);
                _connection.CreateTable<RegistroModel>();
            }

            public IEnumerable<RegistroModel> GetRegistros()
            {
                return _connection.Table<RegistroModel>().ToList();
            }

            public void Insert(RegistroModel registro)
            {
                _connection.Insert(registro);
            }
            public bool IsValidCredentials(string cpf, string senha)
            {
                return _connection.Table<RegistroModel>().Any(r => r.CPF == cpf && r.SENHA == senha);

            }



        }
    }
}
