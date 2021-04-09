namespace StatsApi.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StatsApi.Models;
    using StatsApi.Enums;

    public class ArmourRepo : StatsModelRepo<ArmourStatsModel>
    {
        private readonly IEnumerable<ArmourStatsModel> _allArmourData = new List<ArmourStatsModel>
        {
            new ArmourStatsModel
            {
                Id = 1,
                Name = "Icefall Mantle",
                WeaponType = WeaponType.None,
                Attribute = AttributeType.None,
                Rarity = RarityType.Exotic,
                ArmourType = ArmourType.wrists,
                Strength = 50, 
                Recovery = 24,
                Defence = 20,
                Dicipline = 14, 
                Intellect = 55,
                Mobility = 12,
                Resiliance = 5
            },
            new ArmourStatsModel
            {
                Id = 2,
                Name = "Icefall Mantle",
                WeaponType = WeaponType.None,
                Attribute = AttributeType.None,
                Rarity = RarityType.Exotic,
                ArmourType = ArmourType.wrists,
                Strength = 50,
                Recovery = 24,
                Defence = 20,
                Dicipline = 14,
                Intellect = 55,
                Mobility = 12,
                Resiliance = 5
            },
            new ArmourStatsModel
            {
                Id = 3,                
                Name = "Icefall Mantle",
                WeaponType = WeaponType.None,
                Attribute = AttributeType.None,
                Rarity = RarityType.Exotic,
                ArmourType = ArmourType.wrists,
                Strength = 50,
                Recovery = 24,
                Defence = 20,
                Dicipline = 14,
                Intellect = 55,
                Mobility = 12,
                Resiliance = 5
            },
            new ArmourStatsModel
            {
                Id = 4,            
                Name = "Icefall Mantle",
                WeaponType = WeaponType.None,
                Attribute = AttributeType.None,
                Rarity = RarityType.Exotic,
                ArmourType = ArmourType.wrists,
                Strength = 50,
                Recovery = 24,
                Defence = 20,
                Dicipline = 14,
                Intellect = 55,
                Mobility = 12,
                Resiliance = 5
            },
            new ArmourStatsModel
            {
                Id = 5,                
                Name = "Icefall Mantle",
                WeaponType = WeaponType.None,
                Attribute = AttributeType.None,
                Rarity = RarityType.Exotic,
                ArmourType = ArmourType.wrists,
                Strength = 50,
                Recovery = 24,
                Defence = 20,
                Dicipline = 14,
                Intellect = 55,
                Mobility = 12,
                Resiliance = 5
            },
            new ArmourStatsModel
            {
                Id = 6,                
                Name = "Icefall Mantle",
                WeaponType = WeaponType.None,
                Attribute = AttributeType.None,
                Rarity = RarityType.Exotic,
                ArmourType = ArmourType.wrists,
                Strength = 50,
                Recovery = 24,
                Defence = 20,
                Dicipline = 14,
                Intellect = 55,
                Mobility = 12,
                Resiliance = 5
            },
        };

        public IEnumerable<ArmourStatsModel> GetArmourByRarity(string rarity)
        {
            if (Enum.TryParse(rarity, out RarityType rarityType))
            {
                throw new Exception("Rarity does not exist, check spelling and try again");
            }

            return _allArmourData.Where(x => x.Rarity == rarityType);
        }

        public IEnumerable<ArmourStatsModel> GetArmourByAmourType(string type)
        {
            if (Enum.TryParse(type, out ArmourType weaponType))
            {
                throw new Exception("Armour type does not exist, check spelling and try again");
            }
            return _allArmourData.Where(x => x.ArmourType == weaponType);
        }

        public IEnumerable<ArmourStatsModel> GetArmourByAttribute(string attribute)
        {
            if (Enum.TryParse(attribute, out AttributeType attributeType))
            {
                throw new Exception("Attribute type does not exist, check spelling and try again");
            }
            return _allArmourData.Where(x => x.Attribute == attributeType);
        }

        public override IEnumerable<ArmourStatsModel> GetAll()
        {
            return _allArmourData;
        }
    }
}