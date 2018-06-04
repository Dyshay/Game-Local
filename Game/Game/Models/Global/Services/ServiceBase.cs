using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections;
using ToolBox.Patterns.Repository;

namespace Game.Models.Global.Services
{
    public abstract class ServiceBase<TKey, TEntity> : IDataService<TKey, TEntity>
    {
        private const string CONNECTION_STRING = @"Server=DESKTOP-IRE6555\SQLEXPRESS;Database=Anonymous;Trusted_Connection=True;";

        protected Connection Context { get; set; }

        public ServiceBase()
        {
            Context = new Connection("system.data.sqlclient", CONNECTION_STRING);
        }

        protected abstract TEntity MapperToGlobal(System.Data.IDataRecord Data);

        public abstract bool Delete(TKey ID);
        public abstract IEnumerable<TEntity> Get();
        public abstract TEntity Get(TKey ID);
        public abstract TEntity Insert(TEntity Entity);
        public abstract bool Update(TEntity Entity);
    }
}
