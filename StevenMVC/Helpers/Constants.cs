using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StevenMVC.Helpers
{
    public class Constants
    {
        public const string AllAuthenticationSchemes = "Identity.Application" + "," + JwtBearerDefaults.AuthenticationScheme;
    }
}
