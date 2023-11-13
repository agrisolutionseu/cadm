using System;

namespace AS.FoodPass.CADM.Core.Definitions
{
    public class PlantProtectionType
    {
        /// <summary>
        /// Direct weed and / or disease and / or pest control has been applied
        /// </summary>
        public bool? IsDirectControlUsed { get; set; }
        /// <summary>
        /// Direct chemical control of weeds and / or diseases and / or pests has been used (only if IsDirectControlUsed is True)
        /// </summary>
        public bool? IsChemicalControlUsed { get; set; }
        /// <summary>
        /// The applied PPC is on the list of admitted to trading kept by the MRiRW (Ministerstwo Rolnictwa i Rozwoju Wsi) (only if IsChemicalControlUsed is True)
        /// </summary>
        public bool? IsChemicalControlAllowed { get; set; }
        /// <summary>
        /// The type of PPC / its name / in what dose it was applied per 100 m2 / in what dates e.g. "Insektycyd/Spintor 240 SC/1 ml/20.05.2022, 1,5ml/16.06.2022" (only if IsChemicalControlUsed is True)
        /// </summary>
        public string ChemicalControlName { get; set; }
        /// <summary>
        /// Direct mechanical methods have been used to control weeds and / or diseases and / or pests (only if IsDirectControlUsed is True)
        /// </summary>
        public bool? IsMechanicalControlUsed { get; set; }
        /// <summary>
        /// Direct thermal methods have been used in the control of weeds and / or diseases and / or pests (only if IsDirectControlUsed is True)
        /// </summary>
        public bool? IsThermalControlUsed { get; set; }
        /// <summary>
        /// Direct biological methods are used to control weeds and / or diseases and / or pests (only if IsDirectControlUsed is True)
        /// </summary>
        public bool? IsBiologicalControlUsed { get; set; }
        /// <summary>
        /// Direct conservation biological methods have been used to control weeds and / or diseases and / and pests (only if IsBiologicalControlUsed is True)
        /// </summary>
        public bool? IsBiologicalConservationUsed { get; set; }
        /// <summary>
        /// Flower strips have been established in the vicinity of the field (only if IsBiologicalConservationUsed is True)
        /// </summary>
        public bool? IsFlowerStripsUsed { get; set; }
        /// <summary>
        /// Flower strips with honey plants were established in the vicinity of the field (only if IsBiologicalConservationUsed is True)
        /// </summary> 
        public bool? IsHoneyFlowerStripsUsed { get; set; }
        /// <summary>
        /// Flower strips with plants attracting pest antagonistic insects in the vicinity of the field were established (only if IsBiologicalConservationUsed is True)
        /// </summary>
        public bool? IsAntagonisticInsectsFlowerStripsUsed { get; set; }
        /// <summary>
        /// Biological plant protection products were used to control weeds and / or diseases and / or pests (only if IsBiologicalControlUsed is True)
        /// </summary>
        public bool? IsBiologicalProductsUsed { get; set; }
        /// <summary>
        /// Macro-organisms were used to control weeds and / or diseases and / and pests (only if IsBiologicalProductsUsed is True)
        /// </summary>
        public bool? IsBiologicalProductsMacroUsed { get; set; }
        /// <summary>
        /// Biopesticides have been used to control weeds and / or diseases and / or pests (only if IsBiologicalProductsUsed is True)
        /// </summary>
        public bool? IsBiologicalProductsBiopesticidesUsed { get; set; }
        /// <summary>
        /// Bacterial based biopesticides used to control weeds and / and diseases and / or pests (only if IsBiologicalProductsBiopesticidesUsed is True)
        /// </summary>
        public bool? IsBiologicalProductsBacterialBiopesticidesUsed { get; set; }
        /// <summary>
        /// Biopesticides based on viruses have been used to control weeds and / or diseases and / or pests (only if IsBiologicalProductsBiopesticidesUsed is True)
        /// </summary>
        public bool? IsBiologicalProductsVirusBiopesticidesUsed { get; set; }
        /// <summary>
        /// Biopesticides based on fungi have been used to control weeds and / or diseases and / or pests (only if IsBiologicalProductsBiopesticidesUsed is True)
        /// </summary>
        public bool? IsBiologicalProductsFungiBiopesticidesUsed { get; set; }
        /// <summary>
        /// The type / name of the biopesticide / in what dose it was used per 100 m2 / by what dates (only if IsBiologicalProductsUsed is True)
        /// </summary>
        public string BiologicalProductBiopesticideName { get; set; }
        /// <summary>
        /// Biochemicals were used to control weeds and / or diseases and / and pests (only if IsBiologicalProductsUsed is True)
        /// </summary>
        public bool? IsBiologicalProductsBiochemicalUsed { get; set; }
        /// <summary>
        /// Chemical insect guides were used in pest control (only if IsBiologicalProductsBiochemicalUsed is True)
        /// </summary>
        public bool? IsBiologicalProductsBiochemicalInsectsUsed { get; set; }
        /// <summary>
        /// Compounds of plant origin have been used to control weeds and / or diseases and / and pests (only if IsBiologicalProductsBiochemicalUsed is True)
        /// </summary>
        public bool? IsBiologicalProductsBiochemicalPlantsUsed { get; set; }
        /// <summary>
        /// Prophylactic methods have been used to control weeds and / or diseases and / and pests 
        /// </summary>
        public bool? IsProphylacticUsed { get; set; }
        /// <summary>
        /// The variety used is on the list of varieties recommended  by COBORU (only if IsProphylacticUsed is True)
        /// </summary>
        public bool? IsVarietiesSelectionUsed { get; set; }
        /// <summary>
        /// The planted species is a mixture of varieties (only if IsProphylacticUsed is True)
        /// </summary>
        public bool? IsVarietiesMixtureUsed { get; set; }
        /// <summary>
        /// The crop that is seeded is a mixture of plants (only if IsProphylacticUsed is True)
        /// </summary>
        public bool? IsPlantsMixtureUsed { get; set; }

        /// <summary>
        /// Method to fill values of all properties
        /// </summary>
        public void FillData()
        {
            Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie\n" +
                              $"Czy Stosowano bezpośrednie zwalczanie chwastów lub/i chorób lub/i szkodników? ");
            var answer = Console.ReadLine();
            IsDirectControlUsed = Plot.TryParseAnswerBool(answer);

            if (IsDirectControlUsed == true)
            {
                Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody chemiczne\n" +
                                  $"Czy Stosowano bezpośrednie metody chemiczne zwalczanie chwastów lub/i chorób lub/i szkodników? ");
                answer = Console.ReadLine();
                IsChemicalControlUsed = Plot.TryParseAnswerBool(answer);

                if (IsChemicalControlUsed == true)
                {
                    Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody chemiczne/status środka ochrony roślin (ŚOR)\n" +
                                      $"Czy Zastosowany ŚOR znajduje się na liście dopuszczonych do obrotu prowadzonej przez MRiRW? ");
                    answer = Console.ReadLine();
                    IsChemicalControlAllowed = Plot.TryParseAnswerBool(answer);

                    Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody chemiczne/nazwa ŚOR\n" +
                                      $"Czy Podaj typ ŚOR/jego nazwę/w jakiej dawce go zastosowano na 100 m2/w jakich terminach? ");
                    ChemicalControlName = Console.ReadLine();
                }
                
                Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody mechaniczne\n" +
                                  $"Czy Stosowano bezpośrednie metody mechaniczne w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                answer = Console.ReadLine();
                IsThermalControlUsed = Plot.TryParseAnswerBool(answer);

                Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody termiczne\n" +
                                  $"Czy Stosowano bezpośrednie metody termiczne w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                answer = Console.ReadLine();
                IsMechanicalControlUsed = Plot.TryParseAnswerBool(answer);

                Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne\n" +
                                  $"Czy Stosowano bezpośrednie metody biologiczne w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                answer = Console.ReadLine();
                IsBiologicalControlUsed = Plot.TryParseAnswerBool(answer);

                if(IsBiologicalControlUsed == true)
                {
                    Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/metody konserwacyjne\n" +
                                      $"Czy Stosowano bezpośrednie konserwacyjne metody biologiczne w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                    answer = Console.ReadLine();
                    IsBiologicalConservationUsed = Plot.TryParseAnswerBool(answer);

                    if (IsBiologicalConservationUsed == true)
                    {
                        Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/metody konserwacyjne/pasy kwietne\n" +
                                          $"Czy Założono pasy kwietne w sąsiedztwie pola? ");
                        answer = Console.ReadLine();
                        IsFlowerStripsUsed = Plot.TryParseAnswerBool(answer);

                        Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/metody konserwacyjne/pasy kwietne z roślinami miododajnymi\n" +
                                          $"Czy Założono pasy kwietne  z roślinami miododajnymi w sąsiedztwie pola? ");
                        answer = Console.ReadLine();
                        IsHoneyFlowerStripsUsed = Plot.TryParseAnswerBool(answer);

                        Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/metody konserwacyjne/pasy kwietne z roślinami przyciągającymi owady antagonistyczne do szkodników \n" +
                                          $"Czy Założono pasy kwietne  z roślinamiprzyciągającymi owady antagonistyczne do szkodników w sąsiedztwie pola? ");
                        answer = Console.ReadLine();
                        IsAntagonisticInsectsFlowerStripsUsed = Plot.TryParseAnswerBool(answer);
                    }

                    Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/biologiczne środki ochrony roślin (BŚOR)\n" +
                                      $"Czy Stosowano biologiczne środki ochrony roślin (BŚOR) w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                    answer = Console.ReadLine();
                    IsBiologicalProductsUsed = Plot.TryParseAnswerBool(answer);

                    if (IsBiologicalProductsUsed == true)
                    {
                        Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/biologiczne środki ochrony roślin (BŚOR)/makroorganizmy\n" +
                                          $"Czy Stosowano makroorganizmy w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                        answer = Console.ReadLine();
                        IsBiologicalProductsMacroUsed = Plot.TryParseAnswerBool(answer);

                        Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/biologiczne środki ochrony roślin (BŚOR)/biopestycydy\n" +
                                          $"Czy Stosowano biopestycydy w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                        answer = Console.ReadLine();
                        IsBiologicalProductsBiopesticidesUsed = Plot.TryParseAnswerBool(answer);

                        if (IsBiologicalProductsBiopesticidesUsed == true)
                        {
                            Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/biologiczne środki ochrony roślin (BŚOR)/biopestycydy bazujące na bakteriach\n" +
                                              $"Czy Stosowano biopestycydy bazujące na bakteriach w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                            answer = Console.ReadLine();
                            IsBiologicalProductsBacterialBiopesticidesUsed = Plot.TryParseAnswerBool(answer);

                            Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/biologiczne środki ochrony roślin (BŚOR)/biopestycydy bazujące na wirusach\n" +
                                              $"Czy Stosowano biopestycydy bazujące na wirusach w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                            answer = Console.ReadLine();
                            IsBiologicalProductsFungiBiopesticidesUsed = Plot.TryParseAnswerBool(answer);

                            Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/biologiczne środki ochrony roślin (BŚOR)/biopestycydy bazujące na grzybach\n" +
                                              $"Czy Stosowano biopestycydy bazujące na grzybach w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                            answer = Console.ReadLine();
                            IsBiologicalProductsVirusBiopesticidesUsed = Plot.TryParseAnswerBool(answer);

                            Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/biologiczne środki ochrony roślin (BŚOR)/biopestycydy/nazwa biopestycydu\n" +
                                              $"Czy Podaj typ/nazwę biopestycydu/w jakiej dawce go zastosowano na 100 m2/w jakich terminach? ");
                            BiologicalProductBiopesticideName = Console.ReadLine();
                        }

                        Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/biologiczne środki ochrony roślin (BŚOR)/biopestycydy/biochemikalia\n" +
                                          $"Czy Stosowano biochemikalia w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                        answer = Console.ReadLine();
                        IsBiologicalProductsBiochemicalUsed = Plot.TryParseAnswerBool(answer);

                        if (IsBiologicalProductsBiochemicalUsed == true)
                        {
                            Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/biologiczne środki ochrony roślin (BŚOR)/biopestycydy/biochemikalia/chemiczne informatory owadów\n" +
                                              $"Czy Stosowano chemiczne informatory owadów w zwalczaniu szkodników? ");
                            answer = Console.ReadLine();
                            IsBiologicalProductsBiochemicalInsectsUsed = Plot.TryParseAnswerBool(answer);

                            Console.WriteLine($"Ochrona roślin/bezpośrednie zwalczanie/ metody biologiczne/biologiczne środki ochrony roślin (BŚOR)/biopestycydy/biochemikalia/związki pochodzenia roślinnego\n" +
                                              $"Czy Stosowano związki pochodzenia roślinnego w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
                            answer = Console.ReadLine();
                            IsBiologicalProductsBiochemicalPlantsUsed = Plot.TryParseAnswerBool(answer);
                        }
                    }
                }
            }

            Console.WriteLine($"Ochrona roślin/profilaktyka\n" +
                              $"Czy Stosowano metody profilaktyczne w zwalczaniu chwastów lub/i chorób lub/i szkodników? ");
            answer = Console.ReadLine();
            IsProphylacticUsed = Plot.TryParseAnswerBool(answer);

            if (IsProphylacticUsed == true)
            {
                Console.WriteLine($"Ochrona roślin/profilaktyka/dobór odmian\n" +
                                  $"Czy Wykorzystana odmiana jest na liście odmian rekomendowanych dla danego województwa przez COBORU? ");
                answer = Console.ReadLine();
                IsVarietiesSelectionUsed = Plot.TryParseAnswerBool(answer);

                Console.WriteLine($"Ochrona roślin/profilaktyka/mieszaniny odmian\n" +
                                  $"Czy Wysiany gatunek jest mieszaniną odmian? ");
                answer = Console.ReadLine();
                IsVarietiesMixtureUsed = Plot.TryParseAnswerBool(answer);

                Console.WriteLine($"Ochrona roślin/profilaktyka/uprawy mieszane\n" +
                                  $"Czy Wysiana uprawa jest mieszanką roślin? ");
                answer = Console.ReadLine();
                IsPlantsMixtureUsed = Plot.TryParseAnswerBool(answer);
            }
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