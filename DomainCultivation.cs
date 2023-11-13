using System;
using AS.FarmCloud.Common.Dictionaries;
using AS.FoodPass.CADM.Core.Definitions;

namespace AS.FoodPass.CADM.Core
{
    public class DomainCultivation :IDomain
    {
        //Static
        public CultivationType? CultivationType { get; set; } = null;
        public CultivationSubtype? CultivationSubtype { get; set; } = null;
        public double CultivationArea { get; set; }
        public DateTime CultivationStartTime { get; set; }
        public DateTime CultivationEndTime { get; set; }
        public LocalizationType Localization { get; set; }
        public CultivationCropType LeadCrop { get; set; }
        public CultivationCropType ForeCrop { get; set; }
        public CultivationCropType CatchCrop { get; set; }
        public CultivationCropType AfterCrop { get; set; }
        public CultivationCropType AdditionalCrop { get; set; }

        //Aggregated
        public PlantConditionType PlantCondition { get; set; }

        public string DomainName { get; } = "Uprawa";
        public bool HasStaticData { get; } = true;
        public bool HasAggregatedData { get; } = true;

        public DomainCultivation()
        {
            PlantCondition = new PlantConditionType();
            Localization = new LocalizationType();
            LeadCrop = new CultivationCropType();
            ForeCrop = new CultivationCropType();
            CatchCrop = new CultivationCropType();
            AfterCrop = new CultivationCropType();
            AdditionalCrop = new CultivationCropType();
        }
    }
}