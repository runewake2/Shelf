using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelf.GoodRead.OAuth
{
    public static class OAuthRequestBuilder
    {
        public static Uri CreateRequest(ServiceKey service, string callback, bool mobile = false)
        {
            String url = String.Format("{0}{1}?mobile={2}&oauth_callback={3}", service.ServiceEndpoint, "/oauth/authorize", mobile?"1":"0", callback);
            return new Uri(url, UriKind.Absolute);
        }
    }
}
