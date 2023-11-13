using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for single measure of Soil Temperature at certain depth. Default unit is [C]. Acceptable Values are in range from -50 to 100 [C]
    /// </summary>
    public class SoilTemperatureMeasure : TemperatureMeasure
    {
        /// <summary>
        /// The depth of the soil on which the measurement was made
        /// </summary>
        public SoilTemperatureDepthsEnum Depth { get; set; }

        private static string _ident = "Temperature";
        static SoilTemperatureMeasure()
        {
            SetMinMax(_ident);
        }
        public SoilTemperatureMeasure(double value, DateTime date, SoilTemperatureDepthsEnum depth, UnitType unit = UnitType.Celsius)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Depth = depth;
            Unit = unit;
        }

        public override string ToString()
        {
            return $"Date: {MeasureDate.Date}\tValue: {Value}\tUnit: {Unit}\tDepth: {Depth}\tValue Mix - Value Max: {ValueMin}-{ValueMax}";
        }
    }
}