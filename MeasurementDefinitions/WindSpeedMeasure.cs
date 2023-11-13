using System;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core.Definitions
{
    /// <summary>
    /// Class for single measure of Atmospheric Wind Speed at certain height. Default unit is [m/s]. Acceptable Values are in range from 0 to 30 [m/s]
    /// </summary>
    public class WindSpeedMeasure : MeasureType<WindSpeedMeasure>
    {
        private static string _ident = "WindSpeed";
        static WindSpeedMeasure()
        {
            SetMinMax(_ident);
        }
        /// <summary>
        /// The height on which the measure was made
        /// </summary>
        public WindSpeedHeightsEnum Height { get; set; }
        public WindSpeedMeasure(double value, DateTime date, WindSpeedHeightsEnum height, UnitType unit = UnitType.MeterPerSecond)
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