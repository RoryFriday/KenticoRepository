using System;
using System.Collections.Generic;
using System.Data;
using Data.Mappers;

namespace Data
{
    public abstract class KenticoRepository<T>
    {
        private readonly ISession _session;

        protected KenticoRepository(ISession session)
        {
            _session = session;
        }

        protected abstract string AliasPath { get; }

        protected abstract string Type { get; }

        protected abstract EntityMapper Mapper { get; }

        /// <summary>
        /// Template method for getting data out of Kentico
        /// </summary>
        /// <param name="orderBy">Order results field</param>
        /// <returns>Dataset of results</returns>
        protected DataSet GetData(string orderBy)
        {
            return _session.GetData(AliasPath, Type, orderBy);
        }

        /// <summary>
        /// Template method for getting list of items from kentico - mapped as our domain types
        /// </summary>
        /// <returns>List of items of type T</returns>
        public List<T> ListAll()
        {
            var data = GetData(string.Empty);

            var listItems = new List<T>();

            if (data != null && data.Tables.Count > 0)
            {
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    var item = Mapper.Map(row);
                    listItems.Add((T)Convert.ChangeType(item, typeof(T)));
                }
            }

            return listItems;
        }
    }
}
