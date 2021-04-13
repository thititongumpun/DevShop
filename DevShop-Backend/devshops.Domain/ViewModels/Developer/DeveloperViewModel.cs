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
        public string Status { get; set; }
    }
    public class DeveloperGroupModel
    {
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public string Email { get; set; }
        public string GithubUrl { get; set; } 
        public DateTime JoinedDate { get; set; }
        public string Status { get; set; }
        public ICollection<PositionViewModel> Positions {get;set;} = new HashSet<PositionViewModel>();
    }    
}