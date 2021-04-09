namespace StatsApi.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StatsApi.Models;
    using StatsApi.Enums;

    public abstract class StatsModelRepo<TItem> : IRepo<TItem>
        where TItem : StatsModel
    {
        public abstract IEnumerable<TItem> GetAll();

        public TItem GetById(int id)
        {
            return GetAll().First(x => x.Id == id);
        }

        public IEnumerable<TItem> GetByAttribute(string attribute)
        {
            var parsedAttribute = (AttributeType)Enum.Parse(typeof(AttributeType), attribute);

            return GetAll().Where(w => w.Attribute == parsedAttribute);
        }

        public IEnumerable<TItem> GetByRarity(string rarity)
        {
            var parsedRarity = (RarityType)Enum.Parse(typeof(RarityType), rarity);

            return GetAll().Where(w => w.Rarity == parsedRarity);
        }

        public IEnumerable<TItem> GetByType(string type)
        {
            WeaponType? parsedType = null;
            if (Enum.IsDefined(typeof(WeaponType), type))
            {
                parsedType = (WeaponType)Enum.Parse(typeof(WeaponType), type);
                return GetAll().Where(w => w.WeaponType == parsedType);
            }

            return null;
        }
    }
}