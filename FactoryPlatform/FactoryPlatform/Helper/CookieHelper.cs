using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Security.Principal;

namespace FactoryPlatform.Helper
{
    [Authorize]
    public class CookieHelper
    {
        public static string GetUsuario(IPrincipal User)
        {
            var r = "";
            ClaimsPrincipal principal = User as ClaimsPrincipal;

            if (null != principal)
            {
                foreach (Claim claim in principal.Claims)
                {
                    if (claim.Type == "Usuario")
                    {
                        r = claim.Value;
                    }
                }
            }
            return r;
        }

        public static string GetSessionHash(IPrincipal User)
        {
            var r = "";
            ClaimsPrincipal principal = User as ClaimsPrincipal;

            if (null != principal)
            {
                foreach (Claim claim in principal.Claims)
                {
                    if (claim.Type == "uti")
                    {
                        r = claim.Value;
                    }
                }
            }
            return r;
        }
    }
}
