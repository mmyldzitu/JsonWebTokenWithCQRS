using System.Globalization;

namespace JWTAPP.BACK.Infrastructure.Tools
{
    public class JwtTokenDefaults
    {

       

        public const string ValidAudiance = "http://localhost";
        public const string ValidIssuer = "http://localhost";
        public const string Key = "mmymmymmymmymmy1.";
        public const int Expire = 5;
    }
}
