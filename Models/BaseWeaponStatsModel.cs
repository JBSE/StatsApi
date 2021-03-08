namespace DestinyAPI.Model
{
    public class BaseWeaponStatsModel
    {
        public int Id {get; set;}
        public WeaponType WeaponType {get; set;}
        public RarityType Rarity {get; set;}
        public AttributeType Attribute {get; set;}
        public string Name {get; set;}
        public int Impact {get; set;}
        public int Range {get; set;}
        public int Stability {get; set;}
        public int Handling {get; set;}
        public int ReloadSpeed {get; set;}
        public int RoundsPerMinute {get; set;}
        public int Magazine {get; set;}
    }
}