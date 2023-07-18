using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Sessao10.Entities.Enums;

namespace Sessao10.Entities
{
    abstract internal class Shape
    {
        public Color Corlor { get; set; }


        protected Shape(Color cor)
        {
            Corlor = cor;
        }

        public abstract double Area();
    }
}
