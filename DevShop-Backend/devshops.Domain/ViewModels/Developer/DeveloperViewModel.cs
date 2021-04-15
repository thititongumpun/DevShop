using System;
using System.Collections.Generic;
using devshops.Domain.Common;
using devshops.Domain.ViewModels.Position;

namespace devshops.Domain.Developer.ViewModels
{
    public class DeveloperViewModel : AuditableEntity
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

    public class DeveloperCreateModel : AuditableEntity
    {
        public string DeveloperName { get; set; }
        public string Email { get; set; }
        public string GithubUrl { get; set; }
        public string ImageUrl { get; set; }
        public DateTime JoinedDate { get; set; }
        public string Status { get; set; }
    }
}