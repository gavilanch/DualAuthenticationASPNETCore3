using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StevenMVC.Models
{
    public class UserToken
    {
        
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
