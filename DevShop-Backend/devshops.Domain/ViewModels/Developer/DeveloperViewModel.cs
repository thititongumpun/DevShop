using System.Collections.Generic;
using devshops.Domain.Entities;

namespace devshops.Domain.Developer.ViewModels
{
    public class DeveloperViewModel
    {
        public int DeveloperId {get;set;}
        public string DeveloperName {get;set;}
        public ICollection<Position> Positions {get;set;} = new HashSet<Position>();
    }
}