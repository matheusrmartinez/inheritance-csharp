using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    abstract class Payer
    {
        public string Name { get; set; }
        public double Anualincome { get; set; }

        public Payer()
        {
        }

        public Payer(string name, double anualincome)
        {
            Name = name;
            Anualincome = anualincome;
        }

        public virtual double TaxPayed()
        {
            return TaxPayed();
        }
    }
}
