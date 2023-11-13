using System;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core.Definitions
{
    /// <summary>
    /// Class for single measure of Atmospheric Pressure. Default unit is [hPa]. Acceptable Values are in range from 900 to 1100 [hPa]
    /// </summary>
    public class AtmosphericPressureMeasure : MeasureType<AtmosphericPressureMeasure>
    {
        public static string _ident = "Pressure";
        static AtmosphericPressureMeasure()
        {
            SetMinMax(_ident);
        }
        public AtmosphericPressureMeasure(double value, DateTime date, UnitType unit = UnitType.Hectopascal)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}