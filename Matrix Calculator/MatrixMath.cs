using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Calculator
{
    internal class MatrixMath
    {
        public static float Determinant2x2(float a,float b,float c,float d)
        {
            float ans = (float)((a * d) - (b * c));
            Console.WriteLine("(" + a + "*" + d + ") - (" + b + "*" + c + ")");
            Console.WriteLine(ans);
            return ans;
        }
        public static float Determinant3x3(float a,float b, float c, float d, float e, float f, float g, float h, float i)
        {
            // a,b,c
            // d,e,f
            // g,h,i

            //(aei) - afh - bdi + bfg +cdh - ceg

            float aei = M3(a, e, i);
            Console.WriteLine(a + "*" + e + "*" + i);
            float afh = M3(a, f, h);
            Console.WriteLine(a + "*" + f + "*" + h);
            float bdi = M3(b, d, i);
            Console.WriteLine(b + "*" + d + "*" + i);
            float bfg = M3(b, f, g);
            Console.WriteLine(b + "*" + f + "*" + g);
            float cdh = M3(c, d, h);
            Console.WriteLine(c + "*" + d + "*" + h);
            float ceg = M3(c, e, g);
            Console.WriteLine(c + "*" + e + "*" + g);

            float ans = aei - afh - bdi + bfg + cdh - ceg;
            Console.WriteLine(aei + "-" + afh + "-" + bdi + "+" + bfg + "+" + cdh + "-" + ceg);
            Console.WriteLine(ans);

            return (ans);
        }
        public static void Cofactor2x2(float a, float b, float c, float d)
        {
            float newA = (float)(Math.Pow(-1, 1 + 1) * d);
            float newB = (float)(Math.Pow(-1, 1 + 2) * c);
            float newC = (float)(Math.Pow(-1, 2 + 1) * b);
            float newD = (float)(Math.Pow(-1, 2 + 2) * a);

            Console.WriteLine(a + " " + b);
            Console.WriteLine(c + " " + d);
        }
        public static void Cofactor3x3(float a, float b, float c, float d, float e, float f, float g, float h, float i)
        {
            //Cij = (-1)^i+j * det(MINORij)
            float minorA = Determinant2x2(e,f,h,i);
            float newA = (float)(Math.Pow(-1,1+1) * minorA);
            Console.WriteLine("(-1)^i+j * det(efhi)");

            float minorB = Determinant2x2(d, f, g, i);
            float newB = (float)(Math.Pow(-1,1+2) * minorB);
            Console.WriteLine("(-1)^i+j * det(dfgi)");

            float minorC = Determinant2x2(d,e,g,h);
            float newC = (float)(Math.Pow(-1,1+3) * minorC);
            Console.WriteLine("(-1)^i+j * det(degh)");

            float minorD = Determinant2x2(b,c,h,i);
            float newD = (float)(Math.Pow(-1, 2 + 1) * minorD);
            Console.WriteLine("(-1)^i+j * det(bchi)");

            float minorE = Determinant2x2(a,c,g,i);
            float newE = (float)(Math.Pow(-1, 2 + 2) * minorE);
            Console.WriteLine("(-1)^i+j * det(acgi)");

            float minorF = Determinant2x2(a,b,g,h);
            float newF = (float)(Math.Pow(-1, 2 + 3) * minorF);
            Console.WriteLine("(-1)^i+j * det(abgh)");

            float minorG = Determinant2x2(b,c,e,f);
            float newG = (float)(Math.Pow(-1, 3 + 1) * minorG);
            Console.WriteLine("(-1)^i+j * det(bcef)");

            float minorH = Determinant2x2(a,c,d,f);
            float newH = (float)(Math.Pow(-1, 3 + 2) * minorH);
            Console.WriteLine("(-1)^i+j * det(acdf)");

            float minorI = Determinant2x2(a,b,d,e);
            float newI = (float)(Math.Pow(-1, 3 + 3) * minorI);
            Console.WriteLine("(-1)^i+j * det(abde)");

            Console.WriteLine(newA + " " + newB + " " + newC);
            Console.WriteLine(newD + " " + newE + " " + newF);
            Console.WriteLine(newG + " " + newH + " " + newI);
        }
        public static void Transpose(float a, float b, float c, float d, float e, float f, float g, float h, float i)
        {
            float tempB = d;
            float tempC = g;
            float tempD = b;
            float tempF = h;
            float tempG = c;
            float tempH = f;

            b = tempB;
            c = tempC;
            d = tempD;
            f = tempF;
            g = tempG;
            h = tempH;

            Console.WriteLine(a + " " + b + " " + c);
            Console.WriteLine(d + " " + e + " " + f);
            Console.WriteLine(g + " " + h + " " + i);
        }




        private static float M3(float x, float y, float z)
        {
            return x * y * z;
        }
    }
}
