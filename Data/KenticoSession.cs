using System;
using System.Data;

namespace Data
{
    /// <summary>
    /// Wrapper for Kentico's TreeHelper, used to grab information out of CMS
    /// </summary>
    public class KenticoSession : ISession
    {
        public DataSet GetData(string aliasPath, string type, string orderBy)
        {
            throw new NotImplementedException();
            //return TreeHelper.GetDocuments(SiteContext.CurrentSiteName, DocumentContext.CurrentAliasPath + aliasPath, CultureHelper.GetDefaultCultureCode(SiteContext.CurrentSiteName), false, type, null, orderBy, -1, true, -1);
        }
    }
}
