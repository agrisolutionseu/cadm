using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for single measure of Soil Conductivity. Default unit is [mS/m]. Acceptable Values are in range from 0 to 500 [mS/m]
    /// </summary>
    public class ConductivityMeasure : MeasureType<ConductivityMeasure>
    {
        private static string _ident = "Conductivity";
        static ConductivityMeasure()
        {
            SetMinMax(_ident);
        }
        public ConductivityMeasure(double value, DateTime date, UnitType unit = UnitType.MilliSiemensPerMeter)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}