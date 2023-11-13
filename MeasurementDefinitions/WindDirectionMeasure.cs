using System;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core.Definitions
{
    /// <summary>
    /// Class for single measure of Atmospheric Wind Direction. Default unit is [°]. Acceptable Values are in range from 0 to 360 [°]
    /// </summary>
    public class WindDirectionMeasure : MeasureType<WindDirectionMeasure>
    {
        private static string _ident = "WindDirection";
        static WindDirectionMeasure()
        {
            SetMinMax(_ident);
        }
        public WindDirectionMeasure(double value, DateTime date, UnitType unit = UnitType.Degree)
        {
            value = value > ValueMax ? value % 360 : value; //from (-inf, +inf) -> (-360, 360)
            value = value < ValueMin ? 360 - value : value; //from (-360, 360) -> (0, 360)

            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}