using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Extensions
{
    public class ClaimAuthorizeAttribute : AuthorizeAttribute
    {
        //private readonly string ResourceName;

        public ClaimAuthorizeAttribute(string claimType, string claimValue)
        {
            if (string.IsNullOrEmpty(claimType) || string.IsNullOrEmpty(claimValue))
            {
                throw new ArgumentNullException("Claim Type and Value are required.");
            }
            var resourceName = string.Format("{0}====={1}", claimType, claimValue);
            Policy = resourceName;
        }

    }
}
