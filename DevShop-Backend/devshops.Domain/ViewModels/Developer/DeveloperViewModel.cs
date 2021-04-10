using System;
using System.Collections.Generic;
using devshops.Domain.ViewModels.Position;

namespace devshops.Domain.Developer.ViewModels
{
    public class DeveloperViewModel
    {
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public string Email { get; set; }
        public string GithubUrl { get; set; }
        public DateTime JoinedDate { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public DateTime UpdateDate { get; set; }
        public ICollection<PositionViewModel> Positions {get;set;} = new HashSet<PositionViewModel>();
    }
}