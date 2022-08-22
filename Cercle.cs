using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_02_TP1_Heritage
{
    internal class Cercle : Forme
    {
        public int Rayon { get; set; }

        public Cercle(int Rayon)
        {
            this.Rayon = Rayon;
        }

        public Cercle()
        {
        }

        public override double Aire()
        {
            return Math.PI * this.Rayon * this.Rayon;
        }

        public override double Perimetre()
        {
            return 2 * Math.PI * this.Rayon;
        }

        public override string ToString()
        {
            return
                $"Cercle de rayon {Rayon} \n Aire : {Aire()} \n Perimetre {Perimetre()}\n";
        }
    }

}
