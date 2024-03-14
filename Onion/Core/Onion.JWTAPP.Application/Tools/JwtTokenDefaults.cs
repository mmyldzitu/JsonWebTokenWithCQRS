using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application.Tools
{
    public class JwtTokenDefaults
    {
        public const string ValidAudiance = "http://localhost";
        public const string ValidIssuer = "http://localhost";
        public const string Key = "mmymmymmymmymmy1.";
        public const int Expire = 5;
    }
}
