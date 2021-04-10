using System;
using System.Collections.Generic;

namespace devshops.Domain.Entities
{
    public class Developer
    {
        public int DeveloperId {get;set;}
        public string DeveloperName {get;set; }
        public string Email { get; set; }
        public string GithubUrl { get; set; }
        public DateTime JoinedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}