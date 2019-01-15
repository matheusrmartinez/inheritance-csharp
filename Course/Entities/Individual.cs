using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Individual : Payer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }
        public Individual(string name, double anualincome, double healthexpenditures) : base(name, anualincome)
        {
            HealthExpenditures = healthexpenditures;
        }

        public override double TaxPayed()
        {
            double taxes = 0.0;
            if (Anualincome < 20.000)
            {
                taxes = Anualincome * 0.15;
                if (HealthExpenditures > 0)
                {
                    taxes -= HealthExpenditures * 0.5;
                }
            }

            else if (Anualincome >= 20.000)
            {
                taxes = Anualincome * 0.25;
                if (HealthExpenditures > 0)
                {
                    taxes -= HealthExpenditures * 0.5;
                }
            }
            return taxes;
        }
    }
}
