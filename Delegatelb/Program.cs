using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatelb
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            var method = new PrintAs.Delegate(PrintAs.Error);
            method("test msg");
            #endregion
            #region 2
            float num1, num2;
            Console.WriteLine("Write two num:");
            string buff;
            buff = Console.ReadLine();
            num1 = float.Parse(buff);
            buff = Console.ReadLine();
            num2 = float.Parse(buff);
            Console.Write("Chose act: ");
            MathAction.Binar action;
            switch (Console.ReadKey().KeyChar)
            {
                case '+': action = new MathAction.Binar(MathAction.Sum); break;
                case '-': action = new MathAction.Binar(MathAction.Div); break;
                case '*': action = new MathAction.Binar(MathAction.Mult); break;
                default: action = null; break;
            }

            if (action == null) throw new Exception("Unknown action");
            Console.WriteLine($"\nAnswer: {action.Invoke(num1, num2)}");
            #endregion
            #region 3
            Console.Write("Write num: ");
            float num = float.Parse(Console.ReadLine());
            Console.Write("Chose act: ");
            MathAction.Unar action;
            switch (Console.ReadKey().KeyChar)
            {
                case 'e': action = new MathAction.Unar(MathAction.Even); break;
                case 'n': action = new MathAction.Unar(MathAction.NotEven); break;
               case 'p': action = new MathAction.Unar(MathAction.Prime); break;
                case 'f': action = new MathAction.Unar(MathAction.Fibonacci); break;
                default: action = null; break;
            }
            if (action == null) throw new Exception("Unknown action");
            Console.WriteLine($"\nAnswer: {action(num)}");
            #endregion
        }
    }
}
