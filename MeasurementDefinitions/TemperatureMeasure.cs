using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for general single measure of Temperature. Default unit is [°C]. Acceptable Values are in range from -50 to 100 [°C]
    /// </summary>
    public class TemperatureMeasure : MeasureType<TemperatureMeasure>
    {
        private static string _ident = "Temperature";
        static TemperatureMeasure()
        {
            SetMinMax(_ident);
        }
        public TemperatureMeasure(double value, DateTime date, UnitType unit = UnitType.Celsius)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }

        protected TemperatureMeasure()
        {
            Value = 0;
            Unit = UnitType.Null;
            MeasureDate = DateTime.MinValue;
        }
    }
}