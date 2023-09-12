using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Model
{
    public class Conta
    {
        public int id_conta { get; set; }

        public double saldo { get; set; }

        public double limite { get; set; }

        public string tipo { get; set; }

        public bool ativa { get; set; } = true;

        public int fk_correntista { get; set; }

        public DateTime data_abertura { get; set; }

    }
}
