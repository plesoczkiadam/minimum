using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plesoczki_A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, db;
            Console.WriteLine("Hány nap hómérsékleti adatát kérjem be?");
            Console.Write("n= ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ho = new int[n];
            db = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.nap: ",i+1);
                ho[i] = Convert.ToInt32(Console.ReadLine());
                if (ho[i] >= 15)
                    db++;

            }
            Console.WriteLine("{0} napon volt minimum 15 fok vagy melegebb");
            Console.ReadLine();
        }
    }
}
