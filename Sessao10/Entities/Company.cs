using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao10.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployes { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployes) : base(name, anualIncome)
        {
            NumberOfEmployes = numberOfEmployes;
        }
        public override double Tax()
        {
            if ( NumberOfEmployes > 10 )
            {
                return AnualIncome * (14.00 / 100.00);
            }
            else
            {
                return AnualIncome * (16.00 / 100.00);
            }
        }
    }
}
