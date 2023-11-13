using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core.MeasurementDefinitions
{
    public class FertilizationTreatment
    {
        public DateTime Date { get; set; }
        public string FertilizerName { get; set; }
        public FertilizerTypeEnum FertilizerType { get; set; }

        public double NitrogenPerHectare { get; set; }
        public double PhosphorusPerHectare { get; set; }
        public double PotassiumPerHectare { get; set; }
        public double MagnesiumPerHectare { get; set; }
        public double OrganicMatterPerHectare { get; set; }
        public double MicroElementsPerHectare { get; set; }

        //test
        //public FertilizerApplicationType ApplicationType { get; set; }

        public FertilizationTreatment(DateTime date, string name, FertilizerTypeEnum fertilizerType ,double nitrogen, double phosphorus, double potassium, double magnesium, double organicMatter, double microElements)
        {
            Date = date;
            FertilizerName = name;
            FertilizerType = fertilizerType;
            NitrogenPerHectare = nitrogen;
            PhosphorusPerHectare = phosphorus;
            PotassiumPerHectare = potassium;
            MagnesiumPerHectare = magnesium;
            OrganicMatterPerHectare = organicMatter;
            MicroElementsPerHectare = microElements;
        }

        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()}\tName: {FertilizerName}\tType: {FertilizerType.GetAttribute<DisplayAttribute>().Name}\tN[kg/ha]: {NitrogenPerHectare}\tP[kg/ha]: {PhosphorusPerHectare}\tK[kg/ha]: {PotassiumPerHectare}\tMg[kg/ha]: {MagnesiumPerHectare}\tOM[kg/ha]: {OrganicMatterPerHectare}\tMicro[kg/ha]: {MicroElementsPerHectare}";
        }
    }

    
}