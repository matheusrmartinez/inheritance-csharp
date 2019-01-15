using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Company : Payer
    {
        public int NumberEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualincome, int numberemployees) : base(name, anualincome)
        {
            NumberEmployees = numberemployees;
        }
        public override double TaxPayed()
        {
            double taxes = 0.0;
            if (NumberEmployees <= 10)
            {
                taxes = Anualincome * 0.16;
            }

            else
            {
                taxes = Anualincome * 0.14;
            }
            return taxes;
        }
    }
}
