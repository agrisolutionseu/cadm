using System;
using System.Collections.Generic;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core.Definitions
{
    public class SoilElementsType
    {
        /// <summary>
        /// List of soil elements measurements: Phosphorus, Potassium, Magnesium, Nitrogen, Cadmium, Lead
        /// </summary>
        public List<PhosphorusMeasure> Phosphorus { get; set; } = new List<PhosphorusMeasure>();
        public List<PotassiumMeasure> Potassium { get; set; } = new List<PotassiumMeasure>();
        public List<MagnesiumMeasure> Magnesium { get; set; } = new List<MagnesiumMeasure>();
        public List<NitrogenMineralMeasure> NitrogenMineral { get; set; } = new List<NitrogenMineralMeasure>();
        public List<CadmiumMeasure> Cadmium { get; set; } = new List<CadmiumMeasure>();
        public List<LeadMeasure> Lead{ get; set; } = new List<LeadMeasure>();

        public void AddPhosphorusMeasurement(double value, DateTime date, UnitType unit = UnitType.MilligramPer100Gram) {
            Phosphorus.Add(new PhosphorusMeasure(value,date,unit));
        }
        public void AddPotassiumMeasurement(double value, DateTime date, UnitType unit = UnitType.MilligramPer100Gram) {
            Potassium.Add(new PotassiumMeasure(value, date, unit));
        }
        public void AddMagnesiumMeasurement(double value, DateTime date, UnitType unit = UnitType.MilligramPer100Gram) {
            Magnesium.Add(new MagnesiumMeasure(value, date, unit));
        }
        public void AddNitrogenMineralMeasurement(double value, DateTime date, UnitType unit = UnitType.KilogramPerHectare) {
            NitrogenMineral.Add(new NitrogenMineralMeasure(value, date, unit));
        }
        public void AddCadmiumMeasurement(double value, DateTime date, UnitType unit = UnitType.MilligramPerKilogram) {
            Cadmium.Add(new CadmiumMeasure(value, date, unit));
        }
        public void AddLeadMeasurement(double value, DateTime date, UnitType unit = UnitType.MilligramPerKilogram) {
            Lead.Add(new LeadMeasure(value, date, unit));
        }
    }
}