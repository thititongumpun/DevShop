using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace devshops.Domain.Entities
{
    public class Developer
    {
        [Key]
        public int DeveloperId {get;set;}
        public string DeveloperName {get;set; }
        public string Email { get; set; }
        public string GithubUrl { get; set; }
        public DateTime JoinedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Status { get; set; }
    }
}