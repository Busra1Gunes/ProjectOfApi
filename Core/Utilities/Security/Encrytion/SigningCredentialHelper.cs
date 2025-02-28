using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encrytion
{
    public class SigningCredentialHelper
    {
        public static SigningCredentials CreateSigningCredentials( SecurityKey security) 
        {
            return new SigningCredentials(security, SecurityAlgorithms.HmacSha512);
        }
    }
}
