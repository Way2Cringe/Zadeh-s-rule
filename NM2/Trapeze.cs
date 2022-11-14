using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NM2
{
    internal class Trapeze
    {
        public double p1
            { private set; get; }
        public double p2
            { private set; get; }
        public double p3
            { private set; get; }
        public double p4
            { private set; get; }

        public Trapeze(double p1, double p2, double p3, double p4)
        {
            if (p4 < p3 || p3 < p2 || p2 < p1) throw new Exception("Coordinates are not valid");
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }
        public static Trapeze operator *(Trapeze t1, Trapeze t2)
        {
            return new Trapeze(
            t1.p1 * t2.p1,
            t1.p2 * t2.p2,
            t1.p3 * t2.p3,
            t1.p4 * t2.p4);
        }

        public double getCoord(double x)
        {
            if (x < p1 || x > p4) return 0;             // (-inf, p1) U (p4, +inf)
            if (x <= p2) return (x - p1) / (p2 - p1);   // [p1, p2]
            if (x < p3) return 1;                       // (p2, p3)
            return (p4 - x) / (p4 - p3);                // [p3, p4]
        }
        public (double x, double y)[] getPointsArray(double x1, double x2, int amount)
        {
            if (x2 <= x1) throw new Exception("Coordinates are not valid");
            if (amount < 2) throw new Exception("Amount are not valid");
            (double x, double y)[] Arr = new (double x, double y)[amount];
            for (int i = 0; i<amount; i++)
            {
                double x = x1 + i / (amount - 1.0) * (x2 - x1);
                double y = getCoord(x);
                Arr[i] = (x, y);
            }
            return Arr;
        }
    }
}
