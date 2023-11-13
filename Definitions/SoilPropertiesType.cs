using System;
using System.Collections.Generic;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core.Definitions
{
    public class SoilPropertiesType
    {
        public List<pHMeasure> pH { get; set; } = new List<pHMeasure>();
        public List<OrganicMatterMeasure> OrganicMatter { get; set; } = new List<OrganicMatterMeasure>();
        public List<ConductivityMeasure> Conductivity { get; set; } = new List<ConductivityMeasure>();
        public List<HydrolyticAcidityMeasure> HydrolyticAcidity { get; set; } = new List<HydrolyticAcidityMeasure>();
        public List<CompactionMeasure> Compaction { get; set; } = new List<CompactionMeasure>();
        public List<GrainingMeasure> Graining { get; set; } = new List<GrainingMeasure>();


        public void AddpHMeasurement(double value, DateTime date, UnitType unit = UnitType.pH) {
            pH.Add(new pHMeasure(value, date, unit));
        }
        public void AddOrganicMatterMeasurement(double value, DateTime date, UnitType unit = UnitType.Percent) {
            OrganicMatter.Add(new OrganicMatterMeasure(value, date, unit));
        }
        public void AddConductivityMeasurement(double value, DateTime date, UnitType unit = UnitType.MilliSiemensPerMeter) {
            Conductivity.Add(new ConductivityMeasure(value, date, unit));
        }
        public void AddHydrolyticAcidityMeasurement(double value, DateTime date, UnitType unit = UnitType.CentimolePerKiogram) {
            HydrolyticAcidity.Add(new HydrolyticAcidityMeasure(value, date, unit));
        }
        public void AddCompactionMeasurement(double value, DateTime date, UnitType unit = UnitType.Kilopascal) {
            Compaction.Add(new CompactionMeasure(value, date, unit));
        }
        public void AddGrainingMeasurement(double value, DateTime date, UnitType unit = UnitType.Percent) {
            Graining.Add(new GrainingMeasure(value, date, unit));
        }
    }
}