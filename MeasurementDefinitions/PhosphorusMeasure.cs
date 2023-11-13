using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for a single measurement of soil phosphorus (P2O5) in unit [mg P2O5/100g soil]. Accepted Values of measure are in range from 0.2 to 500 [mg P2O5/100g soil]. This value drops at very low pH.
    /// </summary>
    public class PhosphorusMeasure : MeasureType<PhosphorusMeasure>
    {
        private static string _ident = "Phosphorus";
        static PhosphorusMeasure()
        {
            SetMinMax(_ident);
        }
        public PhosphorusMeasure(double value, DateTime date, UnitType unit = UnitType.MilligramPer100Gram)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}