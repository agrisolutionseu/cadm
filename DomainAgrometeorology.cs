using System;
using System.Linq;
using System.Runtime.CompilerServices;
using AS.FoodPass.CADM.Core.Definitions;
using Console = System.Console;

namespace AS.FoodPass.CADM.Core
{
    public class DomainAgrometeorology : IDomain
    {
        public string DomainName { get; } = "Agrometeorologia";
        public bool HasStaticData { get; } = false;
        public bool HasAggregatedData { get; } = true;

        public SoilType Soil { get; set; } 
        public AtmosphereType Atmosphere { get; set; }

        public DomainAgrometeorology()
        {
            Soil = new SoilType();
            Atmosphere = new AtmosphereType();
        }
    }
}