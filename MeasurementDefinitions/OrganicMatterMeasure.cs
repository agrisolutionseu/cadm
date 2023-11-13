using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    /// <summary>
    /// Class for a single measurement of soil organic matter in unit [%]
    /// </summary>
    public class OrganicMatterMeasure : MeasureType<OrganicMatterMeasure>
    {
        private static string _ident = "OrganicMatter";
        static OrganicMatterMeasure()
        {
            SetMinMax(_ident);
        }
        public OrganicMatterMeasure(double value, DateTime date, UnitType unit = UnitType.Percent)
        {
            value = value < ValueMin ? ValueMin : value;
            value = value > ValueMax ? ValueMax : value;
            Value = value;
            MeasureDate = date;
            Unit = unit;
        }
    }
}