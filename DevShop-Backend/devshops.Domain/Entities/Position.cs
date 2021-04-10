using System.Collections.Generic;

namespace devshops.Domain.Entities
{
    public class Position
    {
        public int PositionId {get;set;}
        public string PositionName {get;set;}

        public ICollection<Developer> DeveloperPosition = new HashSet<Developer>();
    }
}