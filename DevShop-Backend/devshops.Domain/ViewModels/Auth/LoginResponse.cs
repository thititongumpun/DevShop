using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Domain.ViewModels.Auth
{
    public class LoginResponse
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public bool Success { get; set; }
        public DateTime Expiration { get; set; }
        public List<string> Errors { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
