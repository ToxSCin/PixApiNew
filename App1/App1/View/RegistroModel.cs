using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1.View
{
    public class RegistroModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string CPF { get; set; }
        public string NOME { get; set; }
        public string SENHA { get; set; }
    }
}
