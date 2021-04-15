namespace devshops.Domain.Entities
{
    public class DeveloperPositionModel
    {
        public int? DeveloperId {get;set;}
        public DeveloperModel Developer { get; set; }
        public int? PositionId {get;set;}
        public PositionModel Position {get;set;}
    }
}