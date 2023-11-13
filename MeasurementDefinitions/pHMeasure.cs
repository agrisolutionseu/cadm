using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for a single measurement of soil pH in unit [pH]
    /// </summary>
    public class pHMeasure : MeasureType<pHMeasure>
    {
        private static string _ident = "pH";
        static pHMeasure()
        {
            SetMinMax(_ident);
        }
        public pHMeasure(double value, DateTime date, UnitType unit = UnitType.pH)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}