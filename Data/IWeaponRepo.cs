namespace DestinyAPI.Data
{
    using System.Collections.Generic;
    using DestinyAPI.Model;

    public interface IWeaponRepo
    {
        IEnumerable<BaseWeaponStatsModel> GetAllWeapons();
        BaseWeaponStatsModel GetWeaponById(int id);
        IEnumerable<BaseWeaponStatsModel> GetWeaponsByRarity(RarityType rarity);
        IEnumerable<BaseWeaponStatsModel> GetWeaponsByWeaponType(WeaponType type);
        IEnumerable<BaseWeaponStatsModel> GetWeaponsByAttribute(AttributeType attribute);
    }
}