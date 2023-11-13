using System;
using Microsoft.VisualBasic;

namespace AS.FoodPass.CADM.Core.Definitions
{
    public class AgrotechnicsType
    {
        private int? _plantAletrnating;
        /// <summary>
        /// Plant alternating characteristics. Possible values are frequency of occurrence of a given plant in the field during the last 5 years: <br></br>monoculture (1), every other year (2), three-field (3), Norfolk rotating (4), multilateral alternation (5).
        /// </summary>
        public int? PlantAlternating 
        {
            get => _plantAletrnating;
            set {
                if (value < 1)
                    _plantAletrnating = null;
                else if (value > 5)
                    _plantAletrnating = null;
                else
                    _plantAletrnating = value;
            }
        }

        public SowingType Sowing { get; set; } = new SowingType();
        public FarmingSystemDetailsType FarmingSystemDetails { get; set; } = new FarmingSystemDetailsType();
        public PlantProtectionType PlantProtection { get; set; } = new PlantProtectionType();

        /// <summary>
        /// Method to fill values of all properties
        /// </summary>
        public void FillData()
        {
            Console.WriteLine($"\nPart: Agricultural System\n");
            Console.WriteLine("Zmianowanie roślin/historia pola\n" +
                              "Charakterystyka zmianowania (Częstość pojawu rośliny uprawnej na polu w okresie ostatnich 5 lat - liczba 1-5)");

            _ = int.TryParse(Console.ReadLine(), out var a);
            PlantAlternating = a;

            Sowing.FillData();
            FarmingSystemDetails.FillData();
            PlantProtection.FillData();
        }

        /// <summary>
        /// Method to print all property names and values in that structure
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine($"\nPart: Agricultural System\n");
            var property = this.GetType().GetProperties()[0];
            Console.WriteLine($"{property.Name}: {property.GetValue(this, null)}");

            Sowing.PrintData();
            FarmingSystemDetails.PrintData();
            PlantProtection.PrintData();
        }
    }
}