using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for single measure of Soil Salinity. Default unit is [g/kg]. Acceptable Values are in range from 0 to 1000 [g/kg]
    /// </summary>
    public class SalinityMeasure : MeasureType<SalinityMeasure>
    {
        public static string _ident = "Salinity";

        static SalinityMeasure()
        {
            SetMinMax(_ident);
        }

        public SalinityMeasure(double value, DateTime date ,UnitType unit = UnitType.GramPerKilogram)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }

        
    }
}