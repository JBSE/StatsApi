namespace StatsApi.Models
{
    using StatsApi.Enums;

    public class ArmourStatsModel : StatsModel
    {
        public int Defence { get; set; }
        public int Mobility { get; set; }
        public int Resiliance { get; set; }
        public int Dicipline { get; set; }
        public int Intellect { get; set; }
        public int Strength { get; set; }
        public int Recovery { get; set; }
    }
}