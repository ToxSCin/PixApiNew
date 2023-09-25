using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Model
{
    public class Conta
    {
        public int ?id { get; set; }

        public double saldo { get; set; }

        public double limite { get; set; }

        public string tipo { get; set; }

        public bool ativa { get; set; } = true;

        public Correntista id_correntista { get; set; }

        public DateTime data_abertura { get; set; }

    }
}
