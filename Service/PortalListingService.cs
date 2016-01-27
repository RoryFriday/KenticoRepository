using System.Collections.Generic;
using Data;
using Domain;

namespace Service
{
    public class PortalListingService
    {
        private readonly PortalListingRepository _repository;

        public PortalListingService(PortalListingRepository repository)
        {
            _repository = repository;
        }

        public List<PortalListItem> GetListItems()
        {
            return _repository.ListAll();
        } 
    }
}
