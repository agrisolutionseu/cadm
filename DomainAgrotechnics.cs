using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core
{
    public class DomainAgrotechnics : IDomain
    {
        public string DomainName { get; } = "Agrotechnika";
        public bool HasStaticData { get; } = true;
        public bool HasAggregatedData { get; } = false;

        public AgriculturalSystemType AgriculturalSystem { get; set; }
        public AgrotechnicsType Agrotechnics { get; set; }

        public DomainAgrotechnics()
        {
            AgriculturalSystem = new AgriculturalSystemType();
            Agrotechnics = new AgrotechnicsType();
        }
    }
}