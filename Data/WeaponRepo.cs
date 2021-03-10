using System.ComponentModel;
using System;
using System.Collections.Generic;
using DestinyAPI.Data;
using DestinyAPI.Model;

namespace DestinyAPI.Data
{
    public class WeaponRepo : IWeaponRepo
    {
        public IEnumerable<BaseWeaponStatsModel> GetAllWeapons()
        {
            var weapons = new List<BaseWeaponStatsModel>
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
                }
            };
            return weapons;
        }
    }
}