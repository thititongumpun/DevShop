using System.Collections.Generic;

namespace devshops.Domain.Entities
{
    public class Developer
    {
        public int DeveloperId {get;set;}
        public string DeveloperName {get;set;}   

        public ICollection<Position> DeveloperPosition = new HashSet<Position>();
    }
}