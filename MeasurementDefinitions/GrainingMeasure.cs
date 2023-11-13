using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for a single measurement of soil graining in unit [%]. Acceptable values are 0 - 80 [%].
    /// </summary>
    public class GrainingMeasure : MeasureType<GrainingMeasure>
    {
        public static string _ident = "Graining";
        static GrainingMeasure()
        {
            SetMinMax(_ident);
        }
        public GrainingMeasure(double value, DateTime date, UnitType unit = UnitType.Percent)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}