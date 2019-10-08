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

            EmpireInitialization();

            DecileDistribution();

            GamePlay();

            
            

            }
           static void DecileDistribution()
        {
            Console.WriteLine("Let's determine the spending priorities of your galactic empire!");
            Console.WriteLine("To do this, we will assign 10 \"tenths\" of your economy to different categories.");

            int economyDecilesRemaining = 10;
            int generalWelfareDeciles = 0;
            int explorationDeciles = 0;
            int expansionDeciles = 0;
            int developmentDeciles = 0;
            int scienceDeciles = 0;
            int xenoDiplomacyDeciles = 0;
            int fleetDeciles = 0;

            Console.WriteLine("There are " + economyDecilesRemaining + " tenths remaining.");

            while (economyDecilesRemaining > 0)
            {
                Console.WriteLine("Where do you want to put the next tenth of your economic priorities? There are " + economyDecilesRemaining + " left.");
                Console.WriteLine("Currently, there are:");
                Console.WriteLine("1) " + generalWelfareDeciles + " tenths devoted to general welfare.");
                Console.WriteLine("2) " + developmentDeciles + " tenths devoted to economic development.");
                Console.WriteLine("3) " + explorationDeciles + " tenths devoted to galactic exploration.");
                Console.WriteLine("4) " + expansionDeciles + " tenths devoted to empire expansion.");
                Console.WriteLine("5) " + scienceDeciles + " tenths devoted to scientific research.");
                Console.WriteLine("6) " + fleetDeciles + " tenths devoted to fleet production.");
                Console.WriteLine("7 " + xenoDiplomacyDeciles + " tenths devoted to xeno diplomacy.");
                Console.WriteLine("Press a number, 1-7, to add a tenth of your economy to a priority.");
                Console.WriteLine("Press \"H\" for a description of the categories.");
                char allocate = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("");
                // Case statement 1-6 to assign deciles and subtract 1 from deciles remaining.
                switch (allocate)
                {
                    case '1':
                        Console.WriteLine("One-tenth to general welfare.");
                        generalWelfareDeciles += 1;
                        economyDecilesRemaining -= 1;
                        Console.WriteLine(economyDecilesRemaining);
                        break;
                    case '2':
                        Console.WriteLine("One-tenth to economic development.");
                        developmentDeciles += 1;
                        economyDecilesRemaining -= 1;
                        Console.WriteLine(economyDecilesRemaining);
                        break;
                    case '3':
                        Console.WriteLine("One-tenth to galactic exploration.");
                        explorationDeciles += 1;
                        economyDecilesRemaining -= 1;
                        Console.WriteLine(economyDecilesRemaining);
                        break;
                    case '4':
                        Console.WriteLine("One-tenth to empire expansion.");
                        expansionDeciles += 1;
                        economyDecilesRemaining -= 1;
                        Console.WriteLine(economyDecilesRemaining);
                        break;
                    case '5':
                        Console.WriteLine("One-tenth to scientific research.");
                        scienceDeciles += 1;
                        economyDecilesRemaining -= 1;
                        Console.WriteLine(economyDecilesRemaining);
                        break;
                    case '6':
                        Console.WriteLine("One-tenth to fleet production.");
                        fleetDeciles += 1;
                        economyDecilesRemaining -= 1;
                        Console.WriteLine(economyDecilesRemaining);
                        break;
                    case '7':
                        Console.WriteLine("One-tenth to xeno diplomacy.");
                        xenoDiplomacyDeciles += 1;
                        economyDecilesRemaining -= 1;
                        Console.WriteLine(economyDecilesRemaining);
                        break;
                    case 'H':
                        Console.WriteLine("General welfare increases your citizen's well-being. This lowers the risk of adverse events like rebellion and the rate of piracy. (This is not implemented yet.)");
                        Console.WriteLine("Economic development increases the infrastructure on your planets, resulting in a larger \"pool\" of resources each turn.");
                        Console.WriteLine("Galactic exploration is how you discover alien races and colonizable planets.");
                        Console.WriteLine("Empire expansion involves the construction, manning, and fueling of colony ships. When a ship is done, a planet will be colonized, furthering economic growth.");
                        Console.WriteLine("Scientific research results in discoveries, each of which increases your output in one of the categories going forward. (This is not implemented yet.)");
                        Console.WriteLine("Fleet production is shipbuilding. When a ship is built, it joins your fleet. In a war, the empire with the stronger fleet annhilates the empire with the weaker fleet over a period of years, and adds the loser's planets to their colonizable planets.");
                        Console.WriteLine("Xeno diplomacy involves the study of discovered empires, and the training and staffing of diplomats to maintain peaceful relations with those empires.");
                        Console.WriteLine("Press any key to return to resource allocation.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                        break;
                        
                }
            }

        }
           static void Turn()
        {
            
            int developmentBucket = 0;
            int explorationBucket = 0;
            int expansionBucket = 0;
            int scienceBucket = 0;
            int fleetBucket = 0;
            // int xenoDiplomacyBucket = 0;
            // int generalWelfareBucket = 0;

            //Console.WriteLine("Space Year " + spaceYear);
            Console.WriteLine("Your empire spans " + player1.colonizedPlanets + " colonized worlds.");
            Console.WriteLine("Your empire's GDP is " + playerEconomy + " gigacredits.");
            Console.WriteLine("Your fleet is rated at " + playerFleet + " strength.");
            Console.WriteLine("Your astronomers are aware of " + playerHabitablePlanets + " worlds.");
            Thread.Sleep(300);

            GamePlay();
        }
           static void GamePlay()
            {
                //int spaceYear = 1;
                Console.WriteLine("Press \"A\" to adjust resource allocation.");
                if(!Console.KeyAvailable)
                {
                    Turn();
                //spaceYear += 1;
                }
                else
                {
                    DecileDistribution();
                }
            }

           
    }
}


/* To Implement:
 General Welfare
    Rebellion - subtracts from fleet (percentage?)
 Piracy - subtracts from economy (percentage?) - int piracy - 
 SpaceYear
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
