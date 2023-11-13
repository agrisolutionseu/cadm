using System;

namespace AS.FoodPass.CADM.Core.Definitions
{
    public class FarmingSystemDetailsType
    {
        /// <summary>
        /// Is zero tillage applied (direct seeding)
        /// </summary>
        public bool? IsTillageZero { get; set; }
        /// <summary>
        /// Is conservation (no plowing) tillage used
        /// </summary>
        public bool? IsTillageConservation { get; set; }
        /// <summary>
        /// Is traditional (plow) tillage used
        /// </summary>
        public bool? IsTillageTraditional { get; set; }

        /// <summary>
        /// Method to fill values of all properties
        /// </summary>
        public void FillData()
        {
            Console.WriteLine($"System uprawy roli/zerowa\n" +
                              $"Czy Zastosowano zerową uprawę roli (siew bezpośredni)? ");
            var answer = Console.ReadLine();
            IsTillageZero = Plot.TryParseAnswerBool(answer);

            Console.WriteLine($"System uprawy roli/konserwująca\n" +
                              $"Czy Zastosowano konserwującą (bezorkową) uprawę roli? ");
            answer = Console.ReadLine();
            IsTillageConservation = Plot.TryParseAnswerBool(answer);

            Console.WriteLine($"System uprawy roli/płużna\n" +
                              $"Czy Zastosowano tradycyjną (płużną) uprawę roli? ");
            answer = Console.ReadLine();
            IsTillageTraditional = Plot.TryParseAnswerBool(answer);
        }

        /// <summary>
        /// Method to print all property names and values in that structure
        /// </summary>
        public void PrintData()
        {
            foreach (var prop in this.GetType().GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(this, null)}");
            }
        }
    }
}