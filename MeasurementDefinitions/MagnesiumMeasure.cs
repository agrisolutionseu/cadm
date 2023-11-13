using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for a single measurement of soil magnesium (Mg) in unit [mg Mg/100g soil]. Accepted Values of measure are in range from 0.01 to 200 [mg Mg/100g soil]. The content of this element is naturally higher in heavier soils with a greater share of clay
    /// </summary>
    public class MagnesiumMeasure : MeasureType<MagnesiumMeasure>
    {
        private static string _ident = "Magnesium";
        static MagnesiumMeasure()
        {
            SetMinMax(_ident);
        }
        public MagnesiumMeasure(double value, DateTime date, UnitType unit = UnitType.MilligramPer100Gram)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}