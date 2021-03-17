namespace StatsApi.Model
{
    public class StatsModel
    {
        public int Id { get; set; }
        public RarityType Rarity { get; set; }
        public AttributeType Attribute { get; set; }
        public string Name { get; set; }
    }
}