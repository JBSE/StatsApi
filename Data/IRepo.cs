

namespace StatsApi.Data
{
    using System.Collections.Generic;
    using StatsApi.Models;

    public interface IRepo<out TItem> where TItem : StatsModel
    {
        IEnumerable<TItem> GetAll();
        TItem GetById(int id);
        IEnumerable<TItem> GetByRarity(string rarity);
        IEnumerable<TItem> GetByType(string type);
        IEnumerable<TItem> GetByAttribute(string attribute);
    }
}