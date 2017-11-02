using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            Gruszka gruszka1 = new Gruszka();
            Owoc gruszka2 = new Gruszka();
            IJedzenie gruszka3 = new Gruszka();
            gruszka1.Jedzenie();
            ((Owoc)gruszka1).Jedzenie();
            ((Gruszka)gruszka1).Jedzenie();
            ((IJedzenie)gruszka1).Jedzenie();
            Console.WriteLine("---");
            gruszka2.Jedzenie();
            ((Owoc)gruszka2).Jedzenie();
            ((Gruszka)gruszka2).Jedzenie();
            ((IJedzenie)gruszka2).Jedzenie();
            Console.WriteLine("---");
            gruszka3.Jedzenie();
            ((Owoc)gruszka3).Jedzenie();
            ((Gruszka)gruszka3).Jedzenie();
            ((IJedzenie)gruszka3).Jedzenie();
            Console.ReadKey();
        }
    }
}
