using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

// ReSharper disable once IdentifierTypo
namespace netcore_webapi_auth_demo
{
    public static class Config
    {
        // 声明需要保护的API资源
        public static IEnumerable<ApiResource> Apis => new List<ApiResource>()
        {
            new ApiResource("api1","My API")
        };
        
        public static IEnumerable<Client> Clients => new List<Client>()
        {
            new Client
            {
                ClientId = "client",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },
                AllowedScopes = {"api1"}
            }
        };
    }
}
