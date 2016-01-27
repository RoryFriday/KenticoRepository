using System.Collections.Generic;

namespace Data
{
    public interface IRepository<T>
    {
        List<T> ListAll();
    }
}
