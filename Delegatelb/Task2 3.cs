using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatelb
{
    class MathAction
    {
        
        public delegate float Binar(float n1, float n2);
        public static float Sum(float n1, float n2) => n1 + n2;
        public static float Div(float n1, float n2) => n1 - n2;
        public static float Mult(float n1, float n2) => n1 * n2;

      
        public delegate bool Unar(float n);
        public static bool Even(float n) => n % 2 == 0;
        public static bool NotEven(float n) => n % 2 == 1;
        public static bool Prime(float n)
        {
            float center = n / 2;
            for (int i = 2; i < center; i++)
            {
                float checking = n / i;
                if (checking == Convert.ToInt32(checking)) return false;
            }
            return true;
        }
        public static bool Fibonacci(float n)
        {
            for (int num = 1, last = 1; num <= n; (num, last) = (num + last, num))
            {
                if (n == num) return true;
            }

            return false;
        }
    }
}
