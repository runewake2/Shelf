using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelf.GoodRead
{
    /// <summary>
    /// The authentication context stores the development Key and Secret given by GoodReads.
    /// </summary>
    public interface IAuthenticationContext
    {
        string Key { get; }
        string Secret { get; }

        bool UserAuthenticated { get; }
        string OAuthToken { get; }
    }
}
