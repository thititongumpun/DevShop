using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace devshops.Domain.Entities
{
    public class Position
    {
        [Key]
        public int PositionId {get;set;}
        public string PositionName {get;set;}
    }
}