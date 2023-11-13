using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AS.FoodPass.CADM.Core.Definitions
{
    public enum FertilizerTypeEnum
    {
        [Display(Name="Mineralny")] Mineral,
        [Display(Name = "Organiczny")] Organic,
        [Display(Name = "Mineralno-organiczny")] MineralOrganic,
        [Display(Name = "Naturalny")] Natural,
        [Display(Name = "Bioferment z biogazowni")] Bioferment,
        [Display(Name = "Osady ściekowe")] SewageSludge,
    }
}