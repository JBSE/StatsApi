using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using DestinyAPI.Data;
using DestinyAPI.Model;

namespace DestinyAPI.Data
{
    public class WeaponRepo : IWeaponRepo
    {
        private readonly IEnumerable<BaseWeaponStatsModel> _allWeaponData = new List<BaseWeaponStatsModel>
        {
            new BaseWeaponStatsModel
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
            new BaseWeaponStatsModel
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
            new BaseWeaponStatsModel
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
            new BaseWeaponStatsModel
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
            new BaseWeaponStatsModel
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
            new BaseWeaponStatsModel
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

        public IEnumerable<BaseWeaponStatsModel> GetAllWeapons()
        {
            return _allWeaponData;
        }

        BaseWeaponStatsModel IWeaponRepo.GetWeaponById(int id)
        {
            var weaponStats = new BaseWeaponStatsModel();
            foreach (var weapon in _allWeaponData)
            {
                if (weapon.Id == id)
                {
                    weaponStats.Id = id;
                    weaponStats.WeaponType = weapon.WeaponType;
                    weaponStats.Rarity = weapon.Rarity;
                    weaponStats.Attribute = weapon.Attribute;
                    weaponStats.Name = weapon.Name;
                    weaponStats.Impact = weapon.Impact;
                    weaponStats.Range = weapon.Range;
                    weaponStats.Stability = weapon.Stability;
                    weaponStats.Handling = weapon.Handling;
                    weaponStats.ReloadSpeed = weapon.ReloadSpeed;
                    weaponStats.RoundsPerMinute = weapon.RoundsPerMinute;
                    weaponStats.Magazine = weapon.Magazine;
                }
                    
            }

            return weaponStats;
        }

        public IEnumerable<BaseWeaponStatsModel> GetWeaponsByRarity(RarityType rarity)
        {
            return _allWeaponData.Where(x => x.Rarity == rarity);
        }

        public IEnumerable<BaseWeaponStatsModel> GetWeaponsByWeaponType(WeaponType type)
        {
            return _allWeaponData.Where(x => x.WeaponType == type);
        }

        public IEnumerable<BaseWeaponStatsModel> GetWeaponsByAttribute(AttributeType attribute)
        {
            return _allWeaponData.Where(x => x.Attribute == attribute);
        }
    }
}