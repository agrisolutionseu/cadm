using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AS.FoodPass.CADM.Core.Definitions;
using AS.FoodPass.CADM.Core.MeasurementDefinitions;

namespace AS.FoodPass.CADM.Core
{
    public class DomainFertilization :IDomain
    {
        public string DomainName { get; } = "Nawożenie";
        public bool HasStaticData { get; } = true;
        public bool HasAggregatedData { get; } = true;

        //Static
        public bool? IsPrecisionFarming { get; set; } //0
        public bool? IsBasedOnFertilizationPlan { get; set; } //1

        //Output
        public AgricultureTypeEnum? AgricultureType { get; set; } //2
        public bool? IsBasedOnKnowledge { get; set; } //3
        public bool? IsBasedOnSoilAnalysis { get; set; } //4 (7-12)
        public bool? IsBasedOnPlantMonitoring { get; set; } //5
        public bool? IsIntuitive { get; set; } //6

        //Soil analysis based output
        public bool HasRecentNitrogenResults { get; set;} //7
        public bool HasRecentPhosphorusResults { get; set; } //8
        public bool HasRecentPotassiumResults { get; set; } //9
        public bool HasRecentMagnesiumResults { get; set; } //10
        public bool HasRecentCadmiumResults { get; set; } //11
        public bool HasRecentLeadResults { get; set; } //12

        //Plant analysis based output
        //TODO

        //Aggregation
        public List<FertilizationTreatment> Fertilizations { get; set; }

        public DomainFertilization()
        {
            IsPrecisionFarming = null;
            Fertilizations = new List<FertilizationTreatment>();
        }

        public void AddFertilization(DateTime date, string name, FertilizerTypeEnum fertilizerType ,double n, double p, double k, double mg, double om, double micro)
        {
            Fertilizations.Add(new FertilizationTreatment(date,name,fertilizerType, n,p,k,mg,om,micro));
        }
    }
}