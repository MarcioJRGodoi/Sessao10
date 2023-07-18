using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao10.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            if (AnualIncome > 20000.00)
            {
                return AnualIncome * (25.00 / 100.00) - (HealthExpenditures * (50.00 / 100.00));
            }
            else
            {
                return AnualIncome * (15.00 / 100.00) - (HealthExpenditures * (50.00 / 100.00));
            }
        }
    }
}
