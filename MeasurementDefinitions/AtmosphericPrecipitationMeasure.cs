using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for single measure of Atmospheric Precipitation. Default unit is [mm]. Acceptable Values are in range from 0 to 1000 [mm]
    /// </summary>
    public class AtmosphericPrecipitationMeasure : MeasureType<AtmosphericPrecipitationMeasure>
    {
        public static string _ident = "Precipitation";
        static AtmosphericPrecipitationMeasure()
        {
            SetMinMax(_ident);
        }
        //TODO: unit in mm or L/m^2
        public AtmosphericPrecipitationMeasure(double value, DateTime date, UnitType unit = UnitType.Millimeter)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}