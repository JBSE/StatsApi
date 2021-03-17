using System.Collections.Generic;
using System.Linq;
using StatsApi.Model;

namespace StatsApi.Data
{
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
            throw new System.NotImplementedException();
        }

        public IEnumerable<TItem> GetByRarity(string rarity)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<TItem> GetByType(string type)
        {
            throw new System.NotImplementedException();
        }
    }
}