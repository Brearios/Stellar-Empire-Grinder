using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stellar_Empire_Grinder
{
    internal class PlayEmpire : Empire
    {
        public string Name { get; set; }
        public string Adjective { get; set; }
        
        
        public int SpaceYear { get; set; }
        public double DevelopmentBucket { get; set; }
        public double ExplorationBucket { get; set; }
        public double ExpansionBucket { get; set; }
        public double ScienceBucket { get; set; }
        public double FleetBucket { get; set; }

        internal PlayEmpire(string name, string adjective, int economy, int fleet, int colonizedPlanets, int habitablePlanets, int economyDecilesRemaining, int generalWelfareDeciles, int explorationDeciles, 
            int expansionDeciles, int developmentDeciles, int scienceDeciles, int xenoDiplomacyDeciles, int fleetDeciles, int spaceYear, int developmentBucket, int explorationBucket, int expansionBucket, int scienceBucket, int fleetBucket)
        {
            this.Name = name;
            this.Adjective = adjective;
            this.Economy = economy;
            this.Fleet = fleet;
            this.ColonizedPlanets = colonizedPlanets;
            this.HabitablePlanets = habitablePlanets;
            this.EconomyDecilesRemaining = economyDecilesRemaining;
            this.GeneralWelfareDeciles = generalWelfareDeciles;
            this.ExplorationDeciles = explorationDeciles;
            this.ExpansionDeciles = expansionDeciles;
            this.DevelopmentDeciles = developmentDeciles;
            this.ScienceDeciles = scienceDeciles;
            this.XenoDiplomacyDeciles = xenoDiplomacyDeciles;
            this.FleetDeciles = fleetDeciles;
            this.SpaceYear = spaceYear;
            this.DevelopmentBucket = developmentBucket;
            this.ExplorationBucket = explorationBucket;
            this.ExpansionBucket = expansionBucket;
            this.ScienceBucket = scienceBucket;
            this.FleetBucket = fleetBucket;
        }

        internal void DecileDistribution()
        {
            Console.WriteLine("Let's determine the spending priorities of your galactic empire!");
            Console.WriteLine("To do this, we will assign 10 \"tenths\" of your economy to different categories.");
            Console.WriteLine("There are " + EconomyDecilesRemaining + " tenths remaining.");

            while (EconomyDecilesRemaining > 0)
            {
                Console.WriteLine("Where do you want to put the next tenth of your economic priorities? There are " + EconomyDecilesRemaining + " left.");
                Console.WriteLine("Currently, there are:");
                Console.WriteLine("1) " + GeneralWelfareDeciles + " tenths devoted to general welfare.");
                Console.WriteLine("2) " + DevelopmentDeciles + " tenths devoted to economic development.");
                Console.WriteLine("3) " + ExplorationDeciles + " tenths devoted to galactic exploration.");
                Console.WriteLine("4) " + ExpansionDeciles + " tenths devoted to empire expansion.");
                Console.WriteLine("5) " + ScienceDeciles + " tenths devoted to scientific research.");
                Console.WriteLine("6) " + FleetDeciles + " tenths devoted to fleet production.");
                Console.WriteLine("7) " + XenoDiplomacyDeciles + " tenths devoted to xeno diplomacy.");
                Console.WriteLine("Press a number, 1-7, to add a tenth of your economy to a priority.");
                Console.WriteLine("Press \"H\" for a description of the categories.");
                char allocate = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("");
                // Case statement 1-6 to assign deciles and subtract 1 from deciles remaining.
                switch (allocate)
                {
                    case '1':
                        Console.WriteLine("One-tenth to general welfare.");
                        GeneralWelfareDeciles += 1;
                        EconomyDecilesRemaining -= 1;
                        Console.WriteLine(EconomyDecilesRemaining);
                        break;
                    case '2':
                        Console.WriteLine("One-tenth to economic development.");
                        DevelopmentDeciles += 1;
                        EconomyDecilesRemaining -= 1;
                        Console.WriteLine(EconomyDecilesRemaining);
                        break;
                    case '3':
                        Console.WriteLine("One-tenth to galactic exploration.");
                        ExplorationDeciles += 1;
                        EconomyDecilesRemaining -= 1;
                        Console.WriteLine(EconomyDecilesRemaining);
                        break;
                    case '4':
                        Console.WriteLine("One-tenth to empire expansion.");
                        ExpansionDeciles += 1;
                        EconomyDecilesRemaining -= 1;
                        Console.WriteLine(EconomyDecilesRemaining);
                        break;
                    case '5':
                        Console.WriteLine("One-tenth to scientific research.");
                        ScienceDeciles += 1;
                        EconomyDecilesRemaining -= 1;
                        Console.WriteLine(EconomyDecilesRemaining);
                        break;
                    case '6':
                        Console.WriteLine("One-tenth to fleet production.");
                        FleetDeciles += 1;
                        EconomyDecilesRemaining -= 1;
                        Console.WriteLine(EconomyDecilesRemaining);
                        break;
                    case '7':
                        Console.WriteLine("One-tenth to xeno diplomacy.");
                        XenoDiplomacyDeciles += 1;
                        EconomyDecilesRemaining -= 1;
                        Console.WriteLine(EconomyDecilesRemaining);
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


        internal void Turn()
        {
            
            // int xenoDiplomacyBucket = 0;
            // int generalWelfareBucket = 0;

            
            Console.WriteLine("Space Year " + SpaceYear);
            Console.WriteLine("Your empire spans " + ColonizedPlanets + " colonized worlds.");
            Console.WriteLine("Your empire's GDP is " + Economy + " gigacredits.");
            Console.WriteLine("Your fleet is rated at " + Fleet + " strength.");
            Console.WriteLine("Your astronomers are aware of " + HabitablePlanets + " habitable worlds.");
            Console.WriteLine(DevelopmentBucket);
            Thread.Sleep(1500);
            SpaceYear += 1;
            //Console.WriteLine("DevelopmentDeciles = " + DevelopmentDeciles);
            //Console.WriteLine("Math = " + (DevelopmentDeciles * Economy));
            //Console.WriteLine("Division = " + ((DevelopmentDeciles * Economy) / 10));
            DevelopmentBucket += ((DevelopmentDeciles * Economy) / 10);
            Console.WriteLine(DevelopmentBucket);
            if (DevelopmentBucket >= 15)
            {
                DevelopmentBucket -= 15;
                Economy += 1;
                Console.WriteLine("Your GDP has grown!");
            }

            ExplorationBucket += ((ExplorationDeciles * Economy) / 10);
            if (ExplorationBucket >= 15)
            {
                ExplorationBucket -= 15;
                // Random 1-4 for planet roll
                HabitablePlanets += 1;
                Console.WriteLine("Your scouts have discovered a colonizable planet!");
            }
            ExpansionBucket += ((ExpansionDeciles * Economy) / 10);
            if (ExpansionBucket >= 15)
            {
                ExpansionBucket -= 15;
                
                ColonizedPlanets += 1;
                HabitablePlanets -= 1;
                Console.WriteLine("Your people have settled a new world!");
            }
            // ScienceBucket += ((ScienceDeciles * Economy) / 10);
            FleetBucket += ((FleetDeciles * Economy) / 10);
            if (FleetBucket >= 15)
            {
                FleetBucket -= 15;
                Fleet += 1;
                Console.WriteLine("Your navy commissions a new ship!");
            }
            // welfare ExplorationBucket += ((ExplorationDeciles * Economy) / 10);
            // diplomacy ExplorationBucket += ((ExplorationDeciles * Economy) / 10);

            GamePlay();
        }
        internal void GamePlay()
        {
            {
                Console.WriteLine("Press \"A\" to adjust resource allocation.");
                if (!Console.KeyAvailable)
                {
                    Turn();
                    
                }
                else
                {
                    DecileDistribution();
                }
            }
        }
    }
}
