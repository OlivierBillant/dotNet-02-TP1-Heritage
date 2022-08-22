using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_02_TP1_Heritage
{
    internal abstract class Forme
    {
        public abstract double Aire();
        public abstract double Perimetre();

        public override string ToString()
        {
            return $"Aire : {Aire()} \n Perimetre : {Perimetre()}\n";
        }
    }
}
