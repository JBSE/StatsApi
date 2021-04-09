namespace StatsApi.Models
{
    using StatsApi.Enums;

    public class StatsModel
    {
        public int Id { get; set; }
        public RarityType Rarity { get; set; }
        public AttributeType Attribute { get; set; }
        public WeaponType WeaponType { get; set; }
        public ArmourType ArmourType { get; set; }
        public string Name { get; set; }
    }
}