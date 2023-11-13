using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for single measure of Plant Leaf Area Index (LAI). Default unit is dimensionless, because it is ratio of two areas [m^2 / m^2 ] = [-]. Acceptable Values are in range from 0 to 100 
    /// </summary>
    public class LeafAreaIndexMeasure : MeasureType<LeafAreaIndexMeasure>
    {
        private static string _ident = "LAI";
        static LeafAreaIndexMeasure()
        {
            SetMinMax(_ident);
        }
        public LeafAreaIndexMeasure(double value, DateTime date, UnitType unit = UnitType.Null)
        {
            //Min-Max Values are from: https://doi.org/10.1016/B978-008045405-4.00849-1
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}