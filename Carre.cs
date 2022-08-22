using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_02_TP1_Heritage
{
    internal class Carre : Forme
    {
        public int Longueur { get; set; }
        public Carre(int longueur)
        {
            this.Longueur = longueur;
        }

        public Carre()
        {
        }

        public override double Aire()
        {
            return this.Longueur * this.Longueur;
        }

        public override double Perimetre()
        {
            return this.Longueur * 4;
        }

        public override string ToString()
        {
            return
                $"Carré de côté {Longueur} \n {base.ToString()}";
        }
    }
}
