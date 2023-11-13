using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for a single measurement of soil lead (Pb) in unit [mg/kg]. Accepted Values of measure are in range from 0.1 to 5000 [mg/kg].
    /// </summary>
    public class LeadMeasure : MeasureType<LeadMeasure>
    {
        private static string _ident = "Lead";
        static LeadMeasure()
        {
            SetMinMax(_ident);
        }
        public LeadMeasure(double value, DateTime date, UnitType unit = UnitType.MilligramPerKilogram)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}