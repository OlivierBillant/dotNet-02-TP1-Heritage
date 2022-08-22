using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_02_TP1_Heritage
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle(int cote1, int cote2, int cote3)
        {
            A = cote1;
            B = cote2;
            C = cote3;
        }

        public Triangle()
        {
        }

        public override double Aire()
        {
            double p = Perimetre() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double Perimetre()
        {
            return this.A + this.B + this.C;
        }

        public override string ToString()
        {
            return
                $"Triangle de côté A = {A}, B = {B}, C = {C} \n {base.ToString()}";
        }
    }
}
