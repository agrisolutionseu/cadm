using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for single measure of Plant Leaf Greenness. Default unit is dimensionless [-]. Acceptable Values are in range from -1 to 1
    /// </summary>
    public class GreennessMeasure : MeasureType<GreennessMeasure>
    {
        private static string _ident = "Greenness";
        static GreennessMeasure()
        {
            SetMinMax(_ident);
        }
        public GreennessMeasure(double value, DateTime date, UnitType unit = UnitType.Null)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}