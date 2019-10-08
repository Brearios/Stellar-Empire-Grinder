using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stellar_Empire_Grinder
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("How many stars, in billions, are in your galaxy?");
            int stars = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many stellar empires are in your galaxy?");
            int stellarEmpires = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thanks!");
            */

            Console.WriteLine("What is the name of your empire? i.e., America");
            string empireName = Console.ReadLine();
            Console.WriteLine("What is the adjective for your empire? i.e., American");
            string empireAdjective = Console.ReadLine();
            Console.WriteLine("With the discovery of the a new habitable world, the " + empireAdjective + " people enter a new era.");
            Console.WriteLine("This becomes known as \"Space Year One\" as humanity unites to colonize the stars.");

            PlayEmpire player1 = new PlayEmpire(empireName, empireAdjective, 10, 1, 1, 1, 10, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0);

            player1.DecileDistribution();



            //DecileDistribution();


            player1.Turn();

            player1.GamePlay();


        }
    }
}


/* To Implement:
 * Refactor Empire.cs into general empire elements, and player empire elements as PlayEmpire class, inheriting from Empire.
 General Welfare
    Rebellion - subtracts from fleet (percentage?)
 Piracy - subtracts from economy (percentage?) - int piracy - 
 // Random 1-4 (1-8?) for planet roll
    - 2 Habitable Planets
    - 5 Empty Space
    - 1 Enemy Empire  
 ScientificOutputBonus for each category
 Re-check help descriptions
 How do planets affect economic growth? Increase cost of development by devBucket, increase returns by planetMultiplier? - should scale at greater than 1:1
 War over (planets + years)
 War, peace, relationship drift
 Exterminator races - start at 0, automatic war, xenophobic races - start at 250, relations decay at 20 per year, xenophilic races - start at 50, relations decay at 10 per year
    Strained - 100 - decay increased by 10 or 5
    Friendly - 750 - decay decreased by 10 or 5
    Allied or federated - 1000 - decay eliminated - race becomes peaceful toward you
Trade? Research bonuses?
 */
