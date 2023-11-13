using System;
using Microsoft.VisualBasic;

namespace AS.FoodPass.CADM.Core.Definitions
{
    public class AgriculturalSystemType
    {
        /// <summary>
        /// Is the cultivation carried out in the ecological system
        /// </summary>
        public bool? IsOrganicFarming { get; set; }
        /// <summary>
        /// Is the cultivation carried out in a biodynamic system (only if IsOrganicFarming is True)
        /// </summary>
        public bool? IsOrganicFarmingBiodynamicVariant { get; set; }

        /// <summary>
        /// Is the cultivation carried out in an integrated system
        /// </summary>
        public bool? IsIntegratedProduction { get; set; }

        /// <summary>
        /// Is the cultivation carried out in a conventional system
        /// </summary>
        public bool? IsConventionalFarming { get; set; }
        /// <summary>
        /// Is the cultivation carried out in the conventional intensive system (only if IsConventionalFarming is True)
        /// </summary>
        public bool? IsConventionalFarmingIntensiveVariant { get; set; }
        /// <summary>
        /// Is the cultivation carried out in the conventional extensive system (only if IsConventionalFarming is True)
        /// </summary>
        public bool? IsConventionalFarmingExtensiveVariant { get; set; }

        /// <summary>
        /// Method to fill values of all properties
        /// </summary>
        public void FillData()
        {
            Console.WriteLine($"\nPart: Agricultural System\n");
            
            Console.WriteLine($"Rolnictwo ekologiczne\n" +
                              $"Czy uprawa prowadzona jest w systemie ekologicznym?");
            var answer = Console.ReadLine();
            IsOrganicFarming = Plot.TryParseAnswerBool(answer);
            
            if (IsOrganicFarming == true)
            {
                Console.WriteLine($"Rolnictwo ekologiczne/wariant biodynamiczny\n" +
                                  $"Czy uprawa prowadzona jest w systemie biodynamicznym?");
                answer = Console.ReadLine();
                IsOrganicFarmingBiodynamicVariant = Plot.TryParseAnswerBool(answer);
            }

            Console.WriteLine($"Integrowana produkcja\n" +
                              $"Czy uprawa prowadzona jest w systemie integrowanym? ");
            answer = Console.ReadLine();
            IsIntegratedProduction = Plot.TryParseAnswerBool(answer);

            Console.WriteLine($"Rolnictwo konwencjonalne\n" +
                              $"Czy uprawa prowadzona jest w systemie konwencjonalnym? ");
            answer = Console.ReadLine();
            IsConventionalFarming = Plot.TryParseAnswerBool(answer);

            if (IsConventionalFarming == true)
            {
                Console.WriteLine($"Rolnictwo konwencjonalne/wariant intensywny\n" +
                                  $"Czy uprawa prowadzona jest w systemie konwencjonalnym intensywnym? ");
                    answer = Console.ReadLine();
                    IsConventionalFarmingIntensiveVariant = Plot.TryParseAnswerBool(answer);

                    Console.WriteLine($"Rolnictwo konwencjonalne/wariant ekstensywny\n" +
                                      $"Czy uprawa prowadzona jest w systemie konwencjonalnym ekstensywnym? ");
                    answer = Console.ReadLine();
                    IsConventionalFarmingExtensiveVariant = Plot.TryParseAnswerBool(answer);
            }
        }

        /// <summary>
        /// Method to print all property names and values in that structure
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine($"\nPart: Agricultural System\n");
            foreach (var prop in this.GetType().GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(this,null)}");
            }
        }
    }
}