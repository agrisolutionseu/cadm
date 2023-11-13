using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for a single measurement of soil potassium (K2O) in unit [mg K2O/100g soil]. Accepted Values of measure are in range from 0.05 to 300 [mg K2O/100g soil]. The content of this element is naturally higher in heavier soils with a greater share of clay
    /// </summary>
    public class PotassiumMeasure : MeasureType<PotassiumMeasure>
    {
        private static string _ident = "Potassium";
        static PotassiumMeasure()
        {
            SetMinMax(_ident);
        }
        public PotassiumMeasure(double value, DateTime date, UnitType unit = UnitType.MilligramPer100Gram)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}