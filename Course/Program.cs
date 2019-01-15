using System;
using Course.Entities;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int payers = int.Parse(Console.ReadLine());
            List<Payer> list = new List<Payer>();
            for (int iC = 1; iC <= payers; iC++)
            {
                Console.WriteLine($"Tax payer #{iC} data: ");
                Console.Write("Individual or company (i/c)? ");
                char opt = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opt == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthexpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualincome, healthexpenditures));
                }

                else if ( opt == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberemployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualincome, numberemployees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (Payer contribuinte in list)
            {
                Console.WriteLine($"{contribuinte.Name}: $ {contribuinte.TaxPayed().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            double totaltaxes = 0.0;
            foreach (Payer contribuinte in list)
            {
                totaltaxes += contribuinte.TaxPayed();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {totaltaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
