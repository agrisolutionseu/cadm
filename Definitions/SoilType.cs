using System;
using System.Collections.Generic;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core.Definitions
{
    /// <summary>
    /// Class for storing Soil measurement results
    /// </summary>
    public class SoilType
    {
        /// <summary>
        /// Lists of Soil measurements: Salinity, Humidity, Conductivity and Temperature at certain depth
        /// </summary>
        public List<SalinityMeasure> Salinity { get; set; } = new List<SalinityMeasure>();
        public List<HumidityMeasure> Humidity { get; set; } = new List<HumidityMeasure>();
        public List<ConductivityMeasure> Conductivity { get; set; } = new List<ConductivityMeasure>();
        public List<SoilTemperatureMeasure> Temperature { get; set; } = new List<SoilTemperatureMeasure>();

        /// <summary>
        /// Methods that add a new Soil measurements (Salinity, Humidity, Conductivity and Temperature) to data model
        /// </summary>
        public void AddSalinityMeasurement(double value, DateTime date, UnitType unit = UnitType.GramPerKilogram) {
            Salinity.Add(new SalinityMeasure(value, date, unit));
        }
        public void AddHumidityMeasurement(double value, DateTime date, UnitType unit = UnitType.Percent) {
            Humidity.Add(new HumidityMeasure(value, date, unit));
        }
        public void AddConductivityMeasurement(double value, DateTime date, UnitType unit = UnitType.MilliSiemensPerMeter)
        {
            Conductivity.Add(new ConductivityMeasure(value, date, unit));
        }
        public void AddTemperatureMeasurement(double value, DateTime date, SoilTemperatureDepthsEnum depth, UnitType unit = UnitType.Celsius) {
            Temperature.Add(new SoilTemperatureMeasure(value, date, depth, unit));
        }
    }
}