namespace DestinyAPI.Data
{
    using System.Collections.Generic;
    using DestinyAPI.Model;

    public interface IWeaponRepo
    {
        IEnumerable<BaseWeaponStatsModel> GetAllWeapons();
        BaseWeaponStatsModel GetWeaponById(int id);
        BaseWeaponStatsModel GetWeaponsByType(RarityType rarity);
        BaseWeaponStatsModel GetWeaponsByWeaponType(WeaponType type);
        BaseWeaponStatsModel GetWeaponsByAttribute(AttributeType attribute);
    }
}