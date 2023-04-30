using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Claims;

namespace MembersApi.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        private const string CLAIM_TYPE_SCOPE = @"http://schemas.microsoft.com/identity/claims/scope";

        public static string GetClaimValue( this ClaimsPrincipal self, string type )
        { 
            var claim = self.Claims.FirstOrDefault( c => c.Type == type );
            return claim?.Value ?? string.Empty;
        }

        public static string GetName( this ClaimsPrincipal self ) => self.GetClaimValue("name");
        public static string GetUsername( this ClaimsPrincipal self ) => self.GetClaimValue("preferred_username");

        public static bool HasScope( this ClaimsPrincipal self, string scope )
        {
            return self.Claims.FirstOrDefault(
                claim => claim.Type == CLAIM_TYPE_SCOPE && claim.Value == scope ) != null;
        }
    }
}
