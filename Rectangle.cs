using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_02_TP1_Heritage
{
    internal class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public Rectangle(int Largeur, int Longueur)
        {
            this.Largeur = Largeur;
            this.Longueur = Longueur;
        }

        public Rectangle()
        {
        }
        /*public override double Aire()
        {
            return this.Largeur * this.Longueur;
        }*/
        public override double Aire() => this.Largeur * this.Longueur;


        public override double Perimetre()
        {
            return (this.Largeur + this.Longueur) * 2;
        }

        public override string ToString()
        {
            return
                $"Rectangle de longueur {Longueur} et de largeur {Largeur}\n {base.ToString()}";
        }
    }
}
