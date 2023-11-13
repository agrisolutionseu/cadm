using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    public class CompactionMeasure : MeasureType<CompactionMeasure>
    {
        public static string _ident = "Compaction";
        static CompactionMeasure()
        {
            SetMinMax(_ident);
        }
        public CompactionMeasure(double value, DateTime date, UnitType unit = UnitType.Kilopascal)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}