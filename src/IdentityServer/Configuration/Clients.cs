﻿using System.Collections.Generic;
using IdentityServer4.Core.Models;

namespace IdentityServer.Configuration
{
    public class Clients
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientName = "angularclient",
                    ClientId = "angularclient",
                    Flow = Flows.Implicit,
                    RedirectUris = new List<string>
                    {
                        "http://localhost:5000/authorized"
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "httts://localhost:44347/unauthorized.html"
                    },
                    AllowedCorsOrigins = new List<string>
                    {
                        "https://localhost:44347"
                    },
                    AllowedScopes = new List<string>
                    {
                        "openid",
                        "email",
                        "profile",
                        "dataEventRecords",
                        "aReallyCoolScope",
                        "securedFiles",
                        "role"
                    }
                },
                new Client
                {
                    ClientName = "angular2client",
                    ClientId = "angular2client",
                    Flow = Flows.Implicit,
                    RedirectUris = new List<string>
                    {
                        "http://localhost:5000/"

                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "http://localhost:5000/Unauthorized.html"
                    },
                    AllowedCorsOrigins = new List<string>
                    {
                        "https://localhost:5000/",
                        "http://localhost:5000/"
                    },
                    AllowedScopes = new List<string>
                    {
                        "openid",
                        "dataEventRecords",
                        "securedFiles",
                        "role"
                    }
                }
            };
        }
    }
}