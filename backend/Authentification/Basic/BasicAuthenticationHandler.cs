using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace MyGardenPlanner.Server.BE.Authentification.Basic
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return Task.FromResult(
                    AuthenticateResult.Fail("Missing Authorization key"
                ));
            }

            var authorizationHeader = Request.Headers["Authorization"].ToString();

            if (!authorizationHeader.StartsWith("Basic ", StringComparison.OrdinalIgnoreCase))
            {
                return Task.FromResult(
                        AuthenticateResult.Fail("Authorization Header does not start with 'Basic '"
                    ));
            }
            var authBase64Decoded = Encoding.UTF8.GetString(

                Convert.FromBase64String(
                    authorizationHeader.Replace("Basic ", "",
                    StringComparison.OrdinalIgnoreCase
                    )
                )
                );
            var authSplit = authBase64Decoded.Split(new[] { ':' }, 2);

            if (authSplit.Length != 2)
            {
                return Task.FromResult(
                       AuthenticateResult.Fail("Invalid Authorization Header format"
                   ));
            }

            var clientId = authSplit[0];
            var clientSecret = authSplit[1];

            //TO DO:
            //compare to database to confirm authentication
            //Going to hard code to MY username for now.

            if (clientId != "user1" || clientSecret != "password1")
            {
                return Task.FromResult(
                       AuthenticateResult.Fail("Invalid User/Password"
                   ));
            }

            var client = new BasicAuthenticationClient
            {
                AuthenticationType = BasicAuthenticationDefaults.AuthenticationScheme,
                IsAuthenticated = true,
                Name = clientId
            };

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(client, new[]
            {
                new Claim(ClaimTypes.NameIdentifier, clientId),
            }));


            return Task.FromResult(
                AuthenticateResult.Success(
                    new AuthenticationTicket(claimsPrincipal, Scheme.Name
                )));
        }
    }
}
