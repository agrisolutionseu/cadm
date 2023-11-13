using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for single measure of Soil/Atmospheric Humidity. Default unit is [%]. Acceptable Values are in range from 0 to 100 [%]
    /// </summary>
    public class HumidityMeasure : MeasureType<HumidityMeasure>
    {
        private static string _ident = "Humidity";
        static HumidityMeasure()
        {
            SetMinMax(_ident);
        }

        public HumidityMeasure(double value, DateTime date, UnitType unit = UnitType.Percent)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}