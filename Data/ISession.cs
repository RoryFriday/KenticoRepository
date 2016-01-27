using System.Data;

namespace Data
{
    public interface ISession
    {
        DataSet GetData(string aliasPath, string type, string orderBy);
    }
}
