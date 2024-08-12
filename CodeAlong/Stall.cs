using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    internal class Stall
    {
        private List<Hester> Hestene = new List<Hester>()
        {
            new Hester("Storm", 35),
            new Hester("Bjarne", 20),
        };

        public void Stallen()
        {
            foreach (var hester in Hestene)
            {
                Console.WriteLine(hester._navn);
            }

            StallMeny();
        }

        public void StallMeny()
        {
            Console.WriteLine("Hva vil du gjøre is stallen?");
            Console.WriteLine("\n1. Mate hestene dine");
            Console.WriteLine("2. Stelle en av hestene");
            Console.WriteLine("3. Melde en av hestene på et løp");
            var StallRespons = Console.ReadLine();
            int Respons = Convert.ToInt32(StallRespons);

            switch (Respons)
            {
                case 1:
                    Matehesten();
                    break;
                case 2:
                    StelleHesten();
                    break;
                case 3:
                    MeldePåLøp();
                    break;
                default:
                    Console.WriteLine("Vennligst input et gyldig tall");
                    break;
            }




        }


        public void Matehesten()
        {
            Console.WriteLine("Velg en hest du vil gi mat");
            string ValgtHest = Console.ReadLine();
            foreach (var Hest in Hestene)
            {
                if (ValgtHest == Hest._navn)
                {
                    ForeHest(Hest);
                }
                else
                {
                    Console.WriteLine("Velg en hest da!");
                }
            }
            

        }

        public void ForeHest(Hester Hest)
        {
            Console.WriteLine($"Du gir {Hest} fôr");
            Hest.Forehest();
        }


        public void StelleHesten(Hester Hest)
        {
            Console.WriteLine($"Du steller {Hest}");
            Hest.StelleHest();
        }

        public void MeldePåLøp(Hester Hest)
        {


        }





    }
}
