using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sessao10.Entities
{
    internal class OutsourceEmploye : Employe
    {
        public double AdditionalCharge { get; set; }
        public OutsourceEmploye() { }

        public OutsourceEmploye(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (1.1 * AdditionalCharge);
        }
    }
}
