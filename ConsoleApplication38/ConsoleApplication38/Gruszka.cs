using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Gruszka:Owoc, IJedzenie
    {
        public void Jedzenie()
        {
            Console.WriteLine("Jem gruszkę");
        }
    }
}
