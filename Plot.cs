using System;
using System.Linq;
using System.Reflection;
using AS.FoodPass.CADM.Core.Definitions;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;
// ReSharper disable ObjectCreationAsStatement

namespace AS.FoodPass.CADM.Core
{
    public class Plot
    {
        //Domains:
        //Full Static:
        public DomainAgrotechnics Agrotechnics;

        //Hybrid (both static values and aggregation values):
        public DomainSoil Soil;
        public DomainFertilization Fertilization;
        public DomainCultivation Cultivation;

        //Full Aggregation:
        public DomainAgrometeorology Agrometeorology;

        public Plot()
        {
            Agrotechnics = new DomainAgrotechnics();
            Soil = new DomainSoil();
            Fertilization = new DomainFertilization();
            Cultivation = new DomainCultivation();
            Agrometeorology = new DomainAgrometeorology();
            InitStaticData();
        }

        public static bool? TryParseAnswerBool(string answer)
        {
            string ans = answer.ToLower();
            if (ans is "t" or "true" or "p" or "prawda" or "tak" or "y" or "yes" or "1")
                return true;
            if (ans is "f" or "false" or "falsz" or "fałsz" or "n" or "nie" or "no" or "0")
                return false;
            return null;
        }
        public static DateTime GetDateFromUser()
        {
            Console.Write("Podaj datę pomiaru (np. 18/06/2018 lub 18.06.2018): ");
            _ = DateTime.TryParse(Console.ReadLine(), out var date);
            return date;
        }
        public static double GetMeasurementValueFromUser()
        {
            Console.Write("Podaj wynik pomiaru (np. 17 lub 10,53): ");
            _ = double.TryParse(Console.ReadLine().Replace(".", ","), out var value);
            return value;
        }

        /// <summary>
        /// Method to check and update information whether there have been any soil measurements recently (1 year or 5 years, depend on element)
        /// </summary>
        public void UpdateOutputConclusions()
        {
            //Checks if there are any results from last year (nitrogen) or last 5 years (rest of elements)
            Fertilization.HasRecentNitrogenResults = (Soil.Elements.NitrogenMineral.Where(r => (r.MeasureDate - DateTime.Today).Days > -365)).ToList().Count > 0;
            Fertilization.HasRecentPhosphorusResults = (Soil.Elements.Phosphorus.Where(r => (r.MeasureDate - DateTime.Today).Days > -365 * 5)).ToList().Count > 0;
            Fertilization.HasRecentPotassiumResults = (Soil.Elements.Potassium.Where(r => (r.MeasureDate - DateTime.Today).Days > -365 * 5)).ToList().Count > 0;
            Fertilization.HasRecentMagnesiumResults = (Soil.Elements.Magnesium.Where(r => (r.MeasureDate - DateTime.Today).Days > -365 * 5)).ToList().Count > 0;
            Fertilization.HasRecentCadmiumResults = (Soil.Elements.Cadmium.Where(r => (r.MeasureDate - DateTime.Today).Days > -365 * 5)).ToList().Count > 0;
            Fertilization.HasRecentLeadResults = (Soil.Elements.Lead.Where(r => (r.MeasureDate - DateTime.Today).Days > -365 * 5)).ToList().Count > 0;

            if (Fertilization.HasRecentNitrogenResults || Fertilization.HasRecentPhosphorusResults || Fertilization.HasRecentPotassiumResults || Fertilization.HasRecentMagnesiumResults || Fertilization.HasRecentCadmiumResults || Fertilization.HasRecentLeadResults)
                Fertilization.IsBasedOnSoilAnalysis = true;
            else
                Fertilization.IsBasedOnSoilAnalysis = false;

            if (Fertilization.IsBasedOnSoilAnalysis == true || Fertilization.IsBasedOnFertilizationPlan == true)
                Fertilization.IsBasedOnKnowledge = true;
            else
                Fertilization.IsBasedOnKnowledge = false;

            Fertilization.IsIntuitive = Fertilization.IsBasedOnKnowledge != true;
        }
        /// <summary>
        /// Method to call dummy objects and call their static constructors to load static data like Max and Min accepted values for measurements
        /// </summary>
        private void InitStaticData()
        {
            //Agrometeorology
            _ = new SalinityMeasure(1, new DateTime());
            _ = new HumidityMeasure(1, new DateTime());
            _ = new ConductivityMeasure(1, new DateTime());
            _ = new SoilTemperatureMeasure(1, new DateTime(),SoilTemperatureDepthsEnum.Cm5);

            _ = new AtmosphericPressureMeasure(1, new DateTime());
            _ = new AtmosphericPrecipitationMeasure(1, new DateTime());
            _ = new RadiationTotalMeasure(1, new DateTime());
            _ = new RadiationPARMeasure(1, new DateTime());
            _ = new WindSpeedMeasure(1, new DateTime(),WindSpeedHeightsEnum.M10);
            _ = new WindDirectionMeasure(1, new DateTime());
            _ = new TemperatureAtHeightMeasure(1, new DateTime(), TemperatureHeightsEnum.Cm5);

            //Cultivation
            _ = new LeafAreaIndexMeasure(1, new DateTime());
            _ = new GreennessMeasure(1, new DateTime());
            _ = new LeafWetnessMeasure(1, new DateTime());
            _ = new TemperatureMeasure(1, new DateTime());
            _ = new NDVIMeasure(1, new DateTime());

            //Soil
            _ = new PhosphorusMeasure(1, new DateTime());
            _ = new PotassiumMeasure(1, new DateTime());
            _ = new MagnesiumMeasure(1, new DateTime());
            _ = new NitrogenMineralMeasure(1, new DateTime());
            _ = new CadmiumMeasure(1, new DateTime());
            _ = new LeadMeasure(1, new DateTime());

            _ = new pHMeasure(1, new DateTime());
            _ = new OrganicMatterMeasure(1, new DateTime());
            _ = new HydrolyticAcidityMeasure(1, new DateTime());
            _ = new CompactionMeasure(1, new DateTime());
            _ = new GrainingMeasure(1, new DateTime());
        }
    }

    public static class Extensions
    {
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue) where TAttribute : Attribute
        {
            return enumValue.GetType().GetMember(enumValue.ToString()).First().GetCustomAttribute<TAttribute>();
        }
    }
}