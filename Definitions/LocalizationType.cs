namespace AS.FoodPass.CADM.Core.Definitions
{
    public class LocalizationType
    {
        public string LandName { get; set; }
        public string ParcelName { get; set; }
        public int PlotNumber { get; set; }

        public override string ToString()
        {
            return $"\n\tNazwa gruntu: {LandName}\n\tNazwa parceli: {ParcelName}\n\tNumer działki: {PlotNumber:D}";
        }
    }
}