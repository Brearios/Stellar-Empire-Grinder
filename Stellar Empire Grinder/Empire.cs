using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stellar_Empire_Grinder
{
    internal class Empire
    {
        public string Name { get; set; }
        public string Adjective { get; set; }
        public int Economy { get; set; }
        public int Fleet { get; set; }
        public int ColonizedPlanets { get; set; }
        public int HabitablePlanets { get; set; }
        public int EconomyDecilesRemaining { get; set; }
        public int GeneralWelfareDeciles { get; set; }
        public int ExplorationDeciles { get; set; }
        public int ExpansionDeciles { get; set; }
        public int DevelopmentDeciles { get; set; }
        public int ScienceDeciles { get; set; }
        public int XenoDiplomacyDeciles { get; set; }
        public int FleetDeciles { get; set; }

        public Empire(string name, string adjective, int economy, int fleet, int colonizedPlanets, int habitablePlanets, int economyDecilesRemaining, int generalWelfareDeciles, int explorationDeciles, int expansionDeciles, int developmentDeciles, int scienceDeciles, int xenoDiplomacyDeciles, int fleetDeciles)
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
        }

        public void EmpireInitialization()
        {
            Console.WriteLine("What is the name of your empire? i.e., America");
            string empireName = Console.ReadLine();
            Console.WriteLine("What is the adjective for your empire? i.e., American");
            string empireAdjective = Console.ReadLine();
            Console.WriteLine("With the discovery of the a new habitable world, the " + empireAdjective + " people enter a new era.");
            Console.WriteLine("This becomes known as \"Space Year One\" as humanity unites to colonize the stars.");
            Empire player1 = new Empire(empireName, empireAdjective, 10, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0);
        }
    }
}
