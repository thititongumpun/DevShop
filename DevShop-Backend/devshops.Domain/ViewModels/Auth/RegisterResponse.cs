using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Domain.ViewModels.Auth
{
    public class RegisterResponse
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
        public string Role { get; set; }
    }
}
