using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for a single measurement of soil cadmium (Cd) in unit [mg/kg]. Accepted Values of measure are in range from 0.01 to 300 [mg/kg].
    /// </summary>
    public class CadmiumMeasure : MeasureType<CadmiumMeasure>
    {
        public static string _ident = "Cadmium";
        static CadmiumMeasure()
        {
            SetMinMax(_ident);
        }
        public CadmiumMeasure(double value, DateTime date, UnitType unit = UnitType.MilligramPerKilogram)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}