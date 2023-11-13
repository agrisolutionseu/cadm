using System;
using System.Collections.Generic;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core.Definitions
{
    /// <summary>
    /// Class for storing PlantCondition measurement results
    /// </summary>
    public class PlantConditionType
    {
        /// <summary>
        /// Lists of Plant Condition measurements: LAI, Greenness, Wetness, Temperature, NDVI
        /// </summary>
        public List<LeafAreaIndexMeasure> LeafAreaIndex { get; set; }
        public List<GreennessMeasure> Greenness { get; set; }
        public List<LeafWetnessMeasure> LeafWetness { get; set; }
        public List<TemperatureMeasure> Temperature { get; set; }
        public List<NDVIMeasure> NDVI { get; set; }

        public PlantConditionType()
        {
            LeafAreaIndex = new List<LeafAreaIndexMeasure>();
            Greenness = new List<GreennessMeasure>();
            LeafWetness = new List<LeafWetnessMeasure>();
            Temperature = new List<TemperatureMeasure>();
            NDVI = new List<NDVIMeasure>();
        }

        /// <summary>
        /// Methods that add a new PlantCondition measurements (LAI, Greenness, Wetness, Temperature, NDVI) to data model
        /// </summary>
        
        public void AddLeafAreaIndexMeasurement(double value, DateTime date, UnitType unit = UnitType.Null) {
            LeafAreaIndex.Add(new LeafAreaIndexMeasure(value, date, unit));
        }
        public void AddGreennessMeasurement(double value, DateTime date, UnitType unit = UnitType.Null) {
            Greenness.Add(new GreennessMeasure(value, date, unit));
        }
        public void AddLeafWetnessMeasurement(double value, DateTime date, UnitType unit = UnitType.Percent) {
            LeafWetness.Add(new LeafWetnessMeasure(value, date, unit));
        }
        public void AddTemperatureMeasurement(double value, DateTime date, UnitType unit = UnitType.Celsius) {
            Temperature.Add(new TemperatureMeasure(value, date, unit));
        }
        public void AddNDVIMeasurement(double value, DateTime date, UnitType unit = UnitType.Null) {
            NDVI.Add(new NDVIMeasure(value, date, unit));
        }
    }
}