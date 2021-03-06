﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelf.GoodRead
{
    public sealed class ServiceKey : IAuthenticationContext
    {
        private const string _serviceEndpoint = "http://www.goodreads.com";
        private string _key;
        private string _secret;

        private bool _authenticated;
        private string _oauthToken;

        public string Key
        {
            get
            {
                return _key;
            }
        }

        public string Secret
        {
            get
            {
                return _secret;
            }
        }

        public bool UserAuthenticated
        {
            get
            {
                return _authenticated;
            }
        }

        public string OAuthToken
        {
            get
            {
                return _oauthToken;
            }
        }

        private ServiceKey(string key, string secret)
        {
            _key = key;
            _secret = secret;
            _authenticated = false;
            _oauthToken = String.Empty;
        }

        public void AuthorizeUser(string token)
        {
            _authenticated = true;
            _oauthToken = token;
        }

        public void RevokeAuthorization()
        {
            _authenticated = false;
            _oauthToken = String.Empty;
        }

        public static ServiceKey AcquireKey(string key, string secret)
        {
            return new ServiceKey(key, secret);
        }
    }
}
