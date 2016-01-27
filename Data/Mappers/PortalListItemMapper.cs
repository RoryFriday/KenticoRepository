using System;
using System.Data;
using Domain;

namespace Data.Mappers
{
    public class PortalListItemMapper : EntityMapper
    {
        private const string ID = "ID";
        private const string TITLE = "Title";
        private const string LOGOURL = "LogoUrl";
        private const string IMAGEURL = "ImageUrl";
        private const string IMAGECREDIT = "ImageCredit";
        private const string TEXT = "Text";
        private const string PRIMARYCTA = "PrimaryCTA";
        private const string PRIMARYCTATEXT = "PrimaryCTAText";
        private const string TEMPLATENAME = "TemplateName";

        protected override Entity MapEntity(DataRow row)
        {
            return this.Map(row);
        }

        // using hiding technique to override the base Map method, allowing us to control the return type
        private new PortalListItem Map(DataRow row)
        {
            return new PortalListItem()
            {
                Id = (row[ID] != DBNull.Value) ? int.Parse(row[ID].ToString()) : 0,
                Title = (row[TITLE] != DBNull.Value) ? row[TITLE].ToString() : string.Empty,
                LogoUrl = (row[LOGOURL] != DBNull.Value) ? row[LOGOURL].ToString() : string.Empty,
                ImageUrl = (row[IMAGEURL] != DBNull.Value) ? row[IMAGEURL].ToString() : string.Empty,
                ImageCredit = (row[IMAGECREDIT] != DBNull.Value) ? row[IMAGECREDIT].ToString() : string.Empty,
                Text = (row[TEXT] != DBNull.Value) ? row[TEXT].ToString() : string.Empty,
                PrimaryCTA = (row[PRIMARYCTA] != DBNull.Value) ? row[PRIMARYCTA].ToString() : string.Empty,
                PrimaryCTAText = (row[PRIMARYCTATEXT] != DBNull.Value) ? row[PRIMARYCTATEXT].ToString() : string.Empty,
                TemplateName = (row[TEMPLATENAME] != DBNull.Value) ? row[TEMPLATENAME].ToString() : string.Empty
            };
        }
    }
}
