using System;
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
                   Attribute = 
               } 
            }
        }
    }
}