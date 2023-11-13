using System;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    public abstract class MeasureType<T>
    {
        public double Value { get; set; }
        public UnitType Unit { get; set; }
        public DateTime MeasureDate { get; set; }
        public static double ValueMin { get; set; }
        public static double ValueMax { get; set; }

        public override string ToString()
        {
            return $"Date: {MeasureDate.Date}\tValue: {Value}\tUnit: {Unit}\tValue Mix - Value Max: {ValueMin.ToString().Replace(",",".")} to {ValueMax.ToString().Replace(",", ".")}";
        }

        public static void SetMinMax(string _ident)
        {
            var temp = MinMaxValueDictionary._dict[_ident];
            ValueMin = temp[0];
            ValueMax = temp[1];
        }
    }

}