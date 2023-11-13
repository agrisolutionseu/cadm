using System;

namespace AS.FoodPass.CADM.Core.Definitions
{
    public class SowingType
    {
        /// <summary>
        /// Is the seed material used own
        /// </summary>
        public bool? IsSeedMaterialOwn { get; set; }
        /// <summary>
        /// Is the seed material used certified
        /// </summary>
        public bool? IsSeedMaterialCertified { get; set; }
        /// <summary>
        /// Is the seed material used dressed
        /// </summary>
        public bool? IsSeedMaterialDressed { get; set; }
        /// <summary>
        /// Name of the product (if the seed material has been dressed)
        /// </summary>
        public string DressedSeedMaterialProduct { get; set; }
        /// <summary>
        /// Is the seed material of commercial quality used
        /// </summary>
        public bool? IsSeedMaterialQualityCommercial { get; set; }
        /// <summary>
        /// Is the seed material of certified quality used
        /// </summary>
        public bool? IsSeedMaterialQualityCertified { get; set; }
        /// <summary>
        /// Is the seed material of elite quality used
        /// </summary>
        public bool? IsSeedMaterialQualityElite { get; set; }

        /// <summary>
        /// Method to fill values of all properties
        /// </summary>
        public void FillData()
        {
            Console.WriteLine($"Materiał siewny/pochodzenie\n" +
                              $"Czy zastosowano własny materiał siewny? ");
            var answer = Console.ReadLine();
            IsSeedMaterialOwn = Plot.TryParseAnswerBool(answer);

            Console.WriteLine($"Materiał siewny/kwalifikat\n" +
                              $"Czy Zastosowano kwalifikowany materiał siewny? ");
            answer = Console.ReadLine();
            IsSeedMaterialCertified = Plot.TryParseAnswerBool(answer);

            Console.WriteLine($"Materiał siewny/zaprawianie\n" +
                              $"Czy Materiał siewny był zaprawiany? ");
            answer = Console.ReadLine();
            IsSeedMaterialDressed = Plot.TryParseAnswerBool(answer);

            Console.WriteLine($"Materiał siewny/zaprawianie/ środek\n" +
                              $"Jeżeli materiał siewny był zaprawiany, podaj, o ile to możliwe, nazwę środka: ");
            DressedSeedMaterialProduct = Console.ReadLine();

            Console.WriteLine($"Jakość materiału siewnego/ materiał kwalifikowany\n" +
                              $"Czy Zastosowano kwalifikowany materiał siewny w jakości kwalifikowany? ");
            answer = Console.ReadLine();
            IsSeedMaterialQualityCommercial = Plot.TryParseAnswerBool(answer);

            Console.WriteLine($"Jakość materiału siewnego/ materiał elitarny\n" +
                              $"Czy Zastosowano kwalifikowany materiał siewny w jakości elitarny? ");
            answer = Console.ReadLine();
            IsSeedMaterialQualityCertified = Plot.TryParseAnswerBool(answer);

            Console.WriteLine($"Jakość materiału siewnego/ materiał handlowy\n" +
                              $"Czy Zastosowano kwalifikowany materiał siewny w jakości handlowy? ");
            answer = Console.ReadLine();
            IsSeedMaterialQualityElite = Plot.TryParseAnswerBool(answer);
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