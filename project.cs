using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 18.035;
            double b = 3.725;
            double c = 0.071;

            double df = 0;
            double ddf = 0;
            double dfex = 0;

            double dfa = 0;
            double dfb = 0;
            double dfc = 0;

            double f = 0;
            double f_n = 0;
            double da = 0.01;
            double db = 0.001;
            double dc = 0.00001;

            f = Math.Pow((b - c), 2) / (2 * a + b);
            f_n = Math.Pow(((b + db) - (c + dc)), 2) / (2 * (a + da) + (b + db));

            dfa = -1 * (2 * Math.Pow((b - c), 2)) / Math.Pow((2 * a + b), 2);  

            dfb = ((2 * b - 2 * c) / (2 * a + b)) - (Math.Pow((b - c), 2) / Math.Pow((2 * a + b), 2));

            dfc = (-2 * b + 2 * c) / (2 * a + b);

            df = dfa * da + dfb * db + dfc * dc;

            ddf = df / Math.Abs(f);

            dfex = Math.Abs(f - f_n);




            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Результаты: блок 1\n");
            Console.ResetColor();
            Console.WriteLine($"a={a}; b={b}; c={c}; " +
                $"df={df}; ddf={ddf}; dfex={dfex}; df={df}; " +
                $"dfa={dfa}; dfb={dfb}; dfc={dfc}; " +
                $"f={f}; da={da}; db={db}; dc={dc}; \n");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Результаты: блок 2\n");
            Console.ResetColor();
            Console.WriteLine("f");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(f.ToString()+"\n");
            Console.ResetColor();

            Console.WriteLine("Абс ^f");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(df.ToString() + "\n");
            Console.ResetColor();

            Console.WriteLine("Отн ^f");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(ddf.ToString() + "\n");
            Console.ResetColor();

            Console.WriteLine("Экспер ^f");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(dfex.ToString() + "\n");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
