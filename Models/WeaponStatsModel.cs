namespace StatsApi.Models
{
    using StatsApi.Enums;

    public class WeaponStatsModel : StatsModel
    {
        public WeaponType WeaponType {get; set;}
        public int Impact {get; set;}
        public int Range {get; set;}
        public int Stability {get; set;}
        public int Handling {get; set;}
        public int ReloadSpeed {get; set;}
        public int RoundsPerMinute {get; set;}
        public int Magazine {get; set;}
    }
}