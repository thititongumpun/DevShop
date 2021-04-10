namespace devshops.Domain.Entities
{
    public class DeveloperPosition
    {
        public int? DeveloperId {get;set;}
        public Developer Developer { get; set; }
        public int? PositionId {get;set;}
        public Position Position {get;set;}
    }
}