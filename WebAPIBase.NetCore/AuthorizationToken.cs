using System.Collections.Generic;

namespace WebAPIBase.NetCore
{
    public class AuthorizationToken
    {
        public string Iss { get; private set; }

        public string Aud { get; private set; }

        public string Sub { get; private set; }

        public IList<string> Roles { get; private set; }

        public AuthorizationToken(string iss, string aud, string sub, IList<string> additionalRoles)
        {
            Iss = iss;
            Aud = aud;
            Sub = sub;
            Roles = new List<string>() { "User" };
            if (additionalRoles != null)
                foreach (string role in additionalRoles)
                    Roles.Add(role);
        }
    }
}