using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Osoba:IMuzyka, ISport
    {
        public string Graj() //niejawna implentacja
        {
            return "gra";
        }

        string IMuzyka.Graj() //jawna implentacja
        {
            return "muzyka";
        }

        string ISport.Graj() //jawna implementacja
        {
            return "sport";
        }
    }
}
