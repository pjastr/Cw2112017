using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Rower:Pojazd, IJazda, IMuzyka
    {
        public void Jedz()
        {
            Console.WriteLine("Jadę rowerem");
        }

        public void Klakson()
        {
            Console.WriteLine("dryń");
        }
    }
}
