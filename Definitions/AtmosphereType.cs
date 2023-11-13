using System;
using System.Collections.Generic;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core.Definitions
{
    /// <summary>
    /// Class for storing Atmosphere measurement results
    /// </summary>
    public class AtmosphereType
    {
        /// <summary>
        /// Lists of Atmosphere measurements: Humidity, Pressure, Precipitation, Total Radiation, PAR Radiation, Wind Speed, Wind Direction and Temperature at certain height
        /// </summary>
        public List<HumidityMeasure> Humidity { get; set; } = new List<HumidityMeasure>();
        public List<AtmosphericPressureMeasure> Pressure { get; set; } = new List<AtmosphericPressureMeasure>();
        public List<AtmosphericPrecipitationMeasure> Precipitation { get; set; } = new List<AtmosphericPrecipitationMeasure>();
        public List<RadiationTotalMeasure> RadiationTotal { get; set; } = new List<RadiationTotalMeasure>();
        public List<RadiationPARMeasure> RadiationPAR { get; set; } = new List<RadiationPARMeasure>();
        public List<WindSpeedMeasure> WindSpeed { get; set; } = new List<WindSpeedMeasure>();
        public List<WindDirectionMeasure> WindDirection { get; set; } = new List<WindDirectionMeasure>();
        public List<TemperatureAtHeightMeasure> Temperature { get; set; } = new List<TemperatureAtHeightMeasure>();

        /// <summary>
        /// Methods that add a new Plant measurements (Humidity, Pressure, Precipitation, Total Radiation, PAR Radiation, Wind Speed, Wind Direction, Temperature) to data model
        /// </summary>
        public void AddHumidityMeasurement(double value, DateTime date, UnitType unit = UnitType.Percent) {
            Humidity.Add(new HumidityMeasure(value, date, unit));
        }
        public void AddPressureMeasurement(double value, DateTime date, UnitType unit = UnitType.Hectopascal) {
            Pressure.Add(new AtmosphericPressureMeasure(value, date, unit));
        }
        public void AddPrecipitationMeasurement(double value, DateTime date, UnitType unit = UnitType.Millimeter) {
            Precipitation.Add(new AtmosphericPrecipitationMeasure(value, date, unit));
        }
        public void AddRadiationTotalMeasurement(double value, DateTime date, UnitType unit = UnitType.WattPerSquareMeter) {
            RadiationTotal.Add(new RadiationTotalMeasure(value, date, unit));
        }
        public void AddRadiationPARMeasurement(double value, DateTime date, UnitType unit = UnitType.WattPerSquareMeter) {
            RadiationPAR.Add(new RadiationPARMeasure(value, date, unit));
        }
        public void AddWindSpeedMeasurement(double value, DateTime date, WindSpeedHeightsEnum height, UnitType unit = UnitType.MeterPerSecond) {
            WindSpeed.Add(new WindSpeedMeasure(value, date, height, unit));
        }
        public void AddWindDirectionMeasurement(double value, DateTime date, UnitType unit = UnitType.Degree) {
            WindDirection.Add(new WindDirectionMeasure(value, date, unit));
        }
        public void AddTemperatureMeasurement(double value, DateTime date, TemperatureHeightsEnum height, UnitType unit = UnitType.Celsius) {
            Temperature.Add(new TemperatureAtHeightMeasure(value, date, height, unit));
        }
    }
}