using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevineMonAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageADeviner = new Random().Next(18);
            Console.WriteLine("Je suis mineur. Devinez mon age. Saisissez un nombre.");
            int ageSaisieNum = ConversionNum();

            while (ageSaisieNum >= 18)
            {
                Console.WriteLine("Je suis mineur. J'ai moins de 18 ans");

                ageSaisieNum = ConversionNum();
            }

            while (ageSaisieNum != ageADeviner)
             {
                 if (ageSaisieNum > ageADeviner)
                 {
                     Console.WriteLine("Non, moins que ça. ");
                 }
                 else
                 {
                     Console.WriteLine("Non, plus que ça.");
                 }
                 ageSaisieNum = ConversionNum();
             }

            Console.WriteLine("Oui, j'ai bien " + ageSaisieNum + " an(s). Bravo!");

            Console.ReadKey();
        }

        static int ConversionNum()
        {
            string ageSaisie=Console.ReadLine();
            int ageSaisieNum;
            while (int.TryParse(ageSaisie, out ageSaisieNum) == false)
            {
                Console.WriteLine("Il faut saisir un nombre.");
                ageSaisie = Console.ReadLine();
            }
            return ageSaisieNum;
        }
    }


}
