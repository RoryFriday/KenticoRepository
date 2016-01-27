namespace Domain
{
    public class PortalListItem : Entity
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public string LogoUrl { get; set; }

        public string ImageUrl { get; set; }
        
        public string ImageCredit { get; set; }
        
        public string Text { get; set; }
        
        public string PrimaryCTA { get; set; }
        
        public string PrimaryCTAText { get; set; }
        
        public string TemplateName { get; set; }
    }
}