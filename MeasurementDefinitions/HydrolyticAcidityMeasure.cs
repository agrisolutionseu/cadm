using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for a single measurement of soil hydrolytic acidity in unit [cmol/kg].
    /// </summary>
    public class HydrolyticAcidityMeasure : MeasureType<HydrolyticAcidityMeasure>
    {
        private static string _ident = "HydrolyticAcidity";
        static HydrolyticAcidityMeasure()
        {
            SetMinMax(_ident);
        }
        public HydrolyticAcidityMeasure(double value, DateTime date, UnitType unit = UnitType.CentimolePerKiogram)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}