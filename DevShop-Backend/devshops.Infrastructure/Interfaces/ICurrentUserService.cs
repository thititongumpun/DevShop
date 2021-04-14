using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Infrastructure.Interfaces
{
    public interface ICurrentUserService
    {
        string Username { get; }
    }
}
