using System;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core.Definitions
{
    /// <summary>
    /// Class for single measure of Atmospheric Temperature at certain height. Default unit is [C]. Acceptable Values are in range from -50 to 100 [C]
    /// </summary>
    public class TemperatureAtHeightMeasure : TemperatureMeasure
    {
        private static string _ident = "Temperature";
        static TemperatureAtHeightMeasure()
        {
            SetMinMax(_ident);
        }
        /// <summary>
        /// The height on which the measure was made
        /// </summary>
        public TemperatureHeightsEnum Height { get; set; }

        public TemperatureAtHeightMeasure(double value, DateTime date, TemperatureHeightsEnum height, UnitType unit = UnitType.Celsius)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Height = height;
            Unit = unit;
        }

        public override string ToString()
        {
            return $"Date: {MeasureDate.Date}\tValue: {Value}\tUnit: {Unit}\tHeight: {Height}\tValue Mix - Value Max: {ValueMin}-{ValueMax}";
        }
    }
}