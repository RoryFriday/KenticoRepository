using System.Data;
using Domain;

namespace Data.Mappers
{
    public abstract class EntityMapper
    {
        protected abstract Entity MapEntity(DataRow row);

        public Entity Map(DataRow row)
        {
            return this.MapEntity(row);
        }
    }
}
