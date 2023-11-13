using System;
using System.Linq;
using AS.FoodPass.CADM.Core.Definitions;
using static System.Int32;

namespace AS.FoodPass.CADM.Core
{
    public class DomainSoil :IDomain
    {
        private int? _agronomicCategory;
        private int? _soilClass;

        /// <summary>
        /// Information if the soil is organic soil.
        /// </summary>
        public bool? IsSoilOrganic { get; set; }

        /// <summary>
        /// Agronomic category of given soil. The higher the better in terms of drought susceptibility. Accepted values: 1-4
        /// </summary>
        public int? AgronomicCategory
        {
            get => _agronomicCategory;
            set { _agronomicCategory = value switch { < 1 => null, > 4 => null, _ => value }; }
        }
        public string DomainName { get; } = "Gleba";
        public bool HasStaticData { get; } = true;
        public bool HasAggregatedData { get; } = true;

        /// <summary>
        /// Soil class. The lower the better in terms of agricultural suitability. Accepted values: 1-6
        /// </summary>
        public int? SoilClass { 
            get => _soilClass;
            set { _soilClass = value switch { < 1 => null, > 6 => null, _ => value }; }
        }

        //Aggregation
        public SoilElementsType Elements { get; set; }
        public SoilPropertiesType Properties { get; set; }

        public DomainSoil()
        {
            Elements = new SoilElementsType();
            Properties = new SoilPropertiesType();
            AgronomicCategory = null;
            SoilClass = null;
            IsSoilOrganic = null;
        }
    }
}