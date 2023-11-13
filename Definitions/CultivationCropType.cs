namespace AS.FoodPass.CADM.Core.Definitions
{
    public class CultivationCropType
    {
        /// <summary>
        /// Cultivation name.
        /// </summary>
        public string CultivationName { get; set; }
        /// <summary>
        /// The amount of the crop expressed in unit [t/ha].
        /// </summary>
        public double CropAmount { get; set; }
        /// <summary>
        /// Information the remains have been plowed in.
        /// </summary>
        public bool? CropRemainsPlowed { get; set; }

        public override string ToString()
        {
            return $"\n\tNazwa rośliny: {CultivationName}\n\tWielkość plonu[t/ha]: {CropAmount:N2}\n\tCzy resztki przyorane?: {CropRemainsPlowed}";

        }
    }
}