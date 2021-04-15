using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using devshops.Domain.Common;

namespace devshops.Domain.Entities
{
    public class PositionModel
    {
        public int PositionId {get;set;}
        public string PositionName {get;set;}
    }
}