using System.Security.Claims;
using System.Security.Cryptography;
using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Services;

namespace DuendeProfileServiceAspNetCoreIdentity;

public class ProfileService: IProfileService
{
	public async Task GetProfileDataAsync(ProfileDataRequestContext context)
	{
        // context.Subject is the user for whom the result is being made
        // context.Subject.Claims is the claims collection from the user's session cookie at login time
        // context.IssuedClaims is the collection of claims that your logic has decided to return in the response

        if (context.Caller == IdentityServerConstants.ProfileDataCallers.ClaimsProviderAccessToken)
        {
            // access_token
            context.IssuedClaims.Add(new Claim("testAT", "at"));
        }

        if (context.Caller == IdentityServerConstants.ProfileDataCallers.ClaimsProviderIdentityToken)
        {
            // id_token

            var oid = context.Subject.Claims.FirstOrDefault(t => t.Type == "oid");

            if(oid != null)
            {
                context.IssuedClaims.Add(new Claim("oid", oid.Value));
            }
        }

        if (context.Caller == IdentityServerConstants.ProfileDataCallers.UserInfoEndpoint)
        {
            // user_info endpoint
            var oid = context.Subject.Claims.FirstOrDefault(t => t.Type == "oid");

            if (oid != null)
            {
                context.IssuedClaims.Add(new Claim("oid", oid.Value));
            }
        }

        // ALL
        context.IssuedClaims.Add(new Claim("test", "A"));

        var idpClaim = context.Subject.Claims.FirstOrDefault(c => c.Type == "idp");
		if (idpClaim?.Value == "EntraID")
		{

		}

        return;
	}

	public Task IsActiveAsync(IsActiveContext context)
	{
		context.IsActive = true;
		return Task.CompletedTask;
	}
}