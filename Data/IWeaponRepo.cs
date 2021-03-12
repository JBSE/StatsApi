namespace DestinyAPI.Data
{
    using System.Collections.Generic;
    using DestinyAPI.Model;

    public interface IWeaponRepo
    {
        IEnumerable<BaseWeaponStatsModel> GetAllWeapons();
        BaseWeaponStatsModel GetWeaponById(int id);
        IEnumerable<BaseWeaponStatsModel> GetWeaponsByRarity(string rarity);
        IEnumerable<BaseWeaponStatsModel> GetWeaponsByWeaponType(string type);
        IEnumerable<BaseWeaponStatsModel> GetWeaponsByAttribute(string attribute);
    }
}