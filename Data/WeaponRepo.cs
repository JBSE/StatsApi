using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using StatsApi.Data;
using StatsApi.Model;

namespace StatsApi.Data
{
    public class WeaponRepo : StatsModelRepo<WeaponStatsModel>
    {
        private readonly IEnumerable<WeaponStatsModel> _allWeaponData = new List<WeaponStatsModel>
        {
            new WeaponStatsModel
            {
                Id = 1,
                Name = "Suros Regime",
                WeaponType = WeaponType.AutoRifle,
                Attribute = AttributeType.None,
                Rarity = RarityType.Exotic,
                Impact = 56,
                Range = 67,
                Stability = 40,
                Handling = 55,
                ReloadSpeed = 40,
                RoundsPerMinute = 600,
                Magazine = 40
            },
            new WeaponStatsModel
            {
                Id = 2,
                Name = "Rat King",
                WeaponType = WeaponType.SideArm,
                Attribute = AttributeType.None,
                Rarity = RarityType.Exotic,
                Impact = 30,
                Range = 50,
                Stability = 65,
                Handling = 70,
                ReloadSpeed = 50,
                RoundsPerMinute = 100,
                Magazine = 12
            },
            new WeaponStatsModel
            {
                Id = 3,
                Name = "Thunder Lord",
                WeaponType = WeaponType.MachineGun,
                Attribute = AttributeType.Arc,
                Rarity = RarityType.Exotic,
                Impact = 70,
                Range = 65,
                Stability = 70,
                Handling = 85,
                ReloadSpeed = 15,
                RoundsPerMinute = 1000,
                Magazine = 100
            },
            new WeaponStatsModel
            {
                Id = 4,
                Name = "Apostate",
                WeaponType = WeaponType.SniperRifle,
                Attribute = AttributeType.Arc,
                Rarity = RarityType.Legendary,
                Impact = 55,
                Range = 65,
                Stability = 42,
                Handling = 80,
                ReloadSpeed = 35,
                RoundsPerMinute = 300,
                Magazine = 12
            },
            new WeaponStatsModel
            {
                Id = 5,
                Name = "Persuader",
                WeaponType = WeaponType.SniperRifle,
                Attribute = AttributeType.Solar,
                Rarity = RarityType.Legendary,
                Impact = 60,
                Range = 80,
                Stability = 55,
                Handling = 32,
                ReloadSpeed = 33,
                RoundsPerMinute = 122,
                Magazine = 8
            },
            new WeaponStatsModel
            {
                Id = 6,
                Name = "Premonition",
                WeaponType = WeaponType.MachineGun,
                Attribute = AttributeType.Void,
                Rarity = RarityType.Exotic,
                Impact = 22,
                Range = 25,
                Stability = 90,
                Handling = 85,
                ReloadSpeed = 50,
                RoundsPerMinute = 2000,
                Magazine = 65
            },
        };

        public IEnumerable<WeaponStatsModel> GetWeaponsByRarity(string rarity)
        {
            if (Enum.TryParse(rarity, out RarityType rarityType))
            {
                throw new Exception("Rarity does not exist, check spelling and try again");
            }

            return _allWeaponData.Where(x => x.Rarity == rarityType);
        }

        public IEnumerable<WeaponStatsModel> GetWeaponsByWeaponType(string type)
        {
            if (Enum.TryParse(type, out WeaponType weaponType))
            {
                throw new Exception("Weapon type does not exist, check spelling and try again");
            }
            return _allWeaponData.Where(x => x.WeaponType == weaponType);
        }

        public IEnumerable<WeaponStatsModel> GetWeaponsByAttribute(string attribute)
        {
            if (Enum.TryParse(attribute, out AttributeType attributeType))
            {
                throw new Exception("Attribute type does not exist, check spelling and try again");
            }
            return _allWeaponData.Where(x => x.Attribute == attributeType);
        }

        public override IEnumerable<WeaponStatsModel> GetAll()
        {
            return _allWeaponData;
        }
    }
}