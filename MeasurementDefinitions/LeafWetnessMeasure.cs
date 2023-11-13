using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for single measure of Plant Leaf Wetness. Default unit is [%]. Acceptable Values are in range from 0 to 100 [%].
    /// </summary>
    public class LeafWetnessMeasure : MeasureType<LeafWetnessMeasure>
    {
        private static string _ident = "LeafWetness";
        static LeafWetnessMeasure()
        {
            SetMinMax(_ident);
        }
        public LeafWetnessMeasure(double value, DateTime date, UnitType unit = UnitType.Percent)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}