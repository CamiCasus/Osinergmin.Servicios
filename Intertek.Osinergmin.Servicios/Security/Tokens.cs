using Newtonsoft.Json;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Distributed.Services.Security
{
    public class Tokens
    {
        public static async Task<object> GenerateJwt(
                ClaimsIdentity identity, 
                IJwtFactory jwtFactory, 
                string userName, 
                JwtIssuerOptions jwtOptions, 
                JsonSerializerSettings serializerSettings)
        {
            var response = new
            {
                id = identity.Claims.Single(c => c.Type == "id").Value,
                auth_token = await jwtFactory.GenerateEncodedToken(userName, identity),
                expires_in = (int)jwtOptions.ValidFor.TotalSeconds
            };

            return response;
        }
    }
}
