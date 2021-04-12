using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Domain.ViewModels.Position
{
    public class PositionViewModel
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
    }

    public class PositionCreateModel
    {
        public string PositionName { get; set; }
    }
}
