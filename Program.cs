using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practise
{
  internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ALL INPUTS MUST BE IN CAPSLOCKS");
            Console.WriteLine("INPUT THE GENOTYPE OF PARTNER X:");
            string partnerX = Console.ReadLine();

            Console.WriteLine("INPUT THE GENOTYPE OF PARTNER Y:");
            string partnerY = Console.ReadLine();

            DoctorRemark(partnerX, partnerY);

            Console.ReadKey();
        }

        static void DoctorRemark(string partnerX, string partnerY)
        {
            if ((partnerX == "AA" && partnerY == "AA") ||
                (partnerX == "AA" && partnerY == "AS") ||
                (partnerX == "AA" && partnerY == "AC") ||
                (partnerX == "AA" && partnerY == "SS") ||
                (partnerX == "AA" && partnerY == "SC") ||
                (partnerX == "AA" && partnerY == "CC") ||
                (partnerX == "AS" && partnerY == "AA") ||
                (partnerX == "AC" && partnerY == "AA") ||
                (partnerX == "SS" && partnerY == "AA") ||
                (partnerX == "SC" && partnerY == "AA") ||
                (partnerX == "CC" && partnerY == "AA"))
            {
                Console.WriteLine("Can Marry");
            }
            else if (
                (partnerX == "AS" && partnerY == "AS") ||
                (partnerX == "AS" && partnerY == "SS") ||
                (partnerX == "AS" && partnerY == "SC") ||
                (partnerX == "AS" && partnerY == "AC") ||
                (partnerX == "AS" && partnerY == "CC") ||

                (partnerX == "SS" && partnerY == "AS") ||
                (partnerX == "SS" && partnerY == "SS") ||
                (partnerX == "SS" && partnerY == "SC") ||
                (partnerX == "SS" && partnerY == "AC") ||
                (partnerX == "SS" && partnerY == "CC") ||

                (partnerX == "SC" && partnerY == "AS") ||
                (partnerX == "SC" && partnerY == "SS") ||
                (partnerX == "SC" && partnerY == "SC") ||
                (partnerX == "SC" && partnerY == "AC") ||
                (partnerX == "SC" && partnerY == "CC") ||

                (partnerX == "CC" && partnerY == "AS") ||
                (partnerX == "CC" && partnerY == "SS") ||
                (partnerX == "CC" && partnerY == "SC") ||
                (partnerX == "CC" && partnerY == "AC") ||
                (partnerX == "CC" && partnerY == "CC") ||

                (partnerX == "AC" && partnerY == "AS") ||
                (partnerX == "AC" && partnerY == "SS") ||
                (partnerX == "AC" && partnerY == "SC") ||
                (partnerX == "AC" && partnerY == "AC") ||
                (partnerX == "AC" && partnerY == "CC"))
            {
                Console.WriteLine("CANNOT MARRY");
            }
            else
            {
                Console.WriteLine("INVALID DETAILS");
            }

        }
    }


}
