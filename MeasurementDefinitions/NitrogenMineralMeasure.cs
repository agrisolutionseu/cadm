using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for a single measurement of soil mineral nitrogen (N) in unit [kg/ha]. Accepted Values of measure are in range from 0.1 to 500 [kg/ha]. At a lower pH, mineral nitrogen can be more difficult to bind to the soil, microorganisms and plants and it can be more of it temporarily, but it can also be washed out of the soil faster
    /// </summary>
    public class NitrogenMineralMeasure : MeasureType<NitrogenMineralMeasure>
    {
        private static string _ident = "Nitrogen";
        static NitrogenMineralMeasure()
        {
            SetMinMax(_ident);
        }
        public NitrogenMineralMeasure(double value, DateTime date, UnitType unit = UnitType.KilogramPerHectare)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}