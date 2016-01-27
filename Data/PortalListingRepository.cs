using Data.Mappers;
using Domain;

namespace Data
{
    public class PortalListingRepository : KenticoRepository<PortalListItem>
    {
        private PortalListItemMapper _mapper;

        public PortalListingRepository(ISession session) : base(session)
        {
        }

        protected override string AliasPath
        {
            get { return "/PortalListings/%"; }
        }

        protected override string Type
        {
            get { return "ExploreBC.PortalListing"; }
        }

        /// <summary>
        /// Could event DI this in the constructor ...
        /// </summary>
        protected override EntityMapper Mapper
        {
            get
            {
                if (_mapper == null)
                {
                    _mapper = new PortalListItemMapper();
                }

                return _mapper;
            }
        }
    }
}
