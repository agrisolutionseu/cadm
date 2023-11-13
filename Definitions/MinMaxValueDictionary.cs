using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AS.FoodPass.CADM.Core.Definitions
{
    /// <summary>
    /// Class for Dictionary of Minimal/Maximal Values of measurement in format: &lt;"MeasurementName",[MinValue,MaxValue]&gt;
    /// </summary>
    public class MinMaxValueDictionary
    {
        /// <summary>
        /// Dictionary of Minimal/Maximal Values of measurement in format: &lt;"MeasurementName",[MinValue,MaxValue]&gt;
        /// </summary>
        public static Dictionary<string, double[]> _dict = new()
        {
            //Agrometeorology
            {"Salinity",new double[]{0,1000}},
            {"Humidity",new double[]{0,100}},
            {"Conductivity",new double[]{0,500}},
            {"Temperature",new double[]{-50,100}},

            {"Pressure",new double[]{900,1100}},
            {"Precipitation",new double[]{0,1000}},
            {"TotalRadiation",new double[]{0,1380}},
            {"PARRadiation",new double[]{0,100}},
            {"WindSpeed",new double[]{0,30}},
            {"WindDirection",new double[]{0,360}},

            //Cultivation
            {"LAI",new double[]{0,25}},
            {"Greenness",new double[]{-1,1}},
            {"LeafWetness",new double[]{0,100}},
            {"NDVI",new double[]{-1,1}},

            //Soil
            {"Phosphorus",new double[]{0.2,500}},
            {"Potassium",new double[]{0.5,300}},
            {"Magnesium",new double[]{0.01,200}},
            {"Nitrogen",new double[]{0.1,500}},
            {"Cadmium",new double[]{0.01,300}},
            {"Lead",new double[]{0.1,5000}},

            {"pH",new double[]{3,11}},
            {"OrganicMatter",new double[]{0.3,95}},
            {"HydrolyticAcidity",new double[]{0,30}},
            {"Compaction",new double[]{0,3500}},
            {"Graining",new double[]{0,80}},
        };

    }
}