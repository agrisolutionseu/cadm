using System;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core.Definitions
{
    /// <summary>
    /// Class for single measure of Atmospheric Total Radiation. Default unit is [W/m^2]. Acceptable Values are in range from 0 to 1380 [W/m^2]
    /// </summary>
    public class RadiationTotalMeasure : MeasureType<RadiationTotalMeasure>
    {
        private static string _ident = "TotalRadiation";
        static RadiationTotalMeasure()
        {
            SetMinMax(_ident);
        }
        public RadiationTotalMeasure(double value, DateTime date, UnitType unit = UnitType.WattPerSquareMeter)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}