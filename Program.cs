change ninja 123 66756565
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSkiing.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumSki = int.Parse(Console.ReadLine());
            int NumjAKET = int.Parse(Console.ReadLine());
            int NumHELMET = int.Parse(Console.ReadLine());
            int NumShoe = int.Parse(Console.ReadLine());

            int Jaketprice = NumjAKET * 120;
            int Helmetprice = NumHELMET * 75;
            double Shoeprice = NumShoe *  299.9;

            double ONEskip = Jaketprice + Helmetprice + Shoeprice;
            double AllSki = ONEskip * NumSki;

            double SumDDS = AllSki * 1.2;

            Console.WriteLine("{0:F2}", SumDDS);


        }
    }
}
