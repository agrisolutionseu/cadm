using System;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core.Definitions
{
    /// <summary>
    /// Class for single measure of Atmospheric PAR Radiation. Default unit is [W/m^2]. Acceptable Values are in range from 0 to 100 [W/m^2]
    /// </summary>
    public class RadiationPARMeasure : MeasureType<RadiationPARMeasure>
    {
        private static string _ident = "PARRadiation";
        static RadiationPARMeasure()
        {
            SetMinMax(_ident);
        }
        public RadiationPARMeasure(double value, DateTime date, UnitType unit = UnitType.WattPerSquareMeter)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}