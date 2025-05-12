using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HASH_Checker
{
    internal class WeightColor
    {
        internal static Color ComputeWeightColor(int intWeight, int maxWeight)
        {
            if (maxWeight == 1)
            {
                return Color.Black;
            }
            else
            {
                return HsvToRgb(((Convert.ToDouble(intWeight)) / Convert.ToDouble(maxWeight)) * 360, 100, 100);
            }
        }
        
        private static Color HsvToRgb(double h, double s, double v)
        {
            s /= 100.0;
            v /= 100.0;

            int hi = Convert.ToInt32(Math.Floor(h / 60)) % 6;
            double f = (h / 60) - Math.Floor(h / 60);

            double p = v * (1 - s);
            double q = v * (1 - f * s);
            double t = v * (1 - (1 - f) * s);

            (double r, double g, double b) = hi switch
            {
                0 => (v, t, p),
                1 => (q, v, p),
                2 => (p, v, t),
                3 => (p, q, v),
                4 => (t, p, v),
                _ => (v, p, q)
            };

            return Color.FromArgb(
                (int)(r * 255),
                (int)(g * 255),
                (int)(b * 255)
            );
        }
    }
}
