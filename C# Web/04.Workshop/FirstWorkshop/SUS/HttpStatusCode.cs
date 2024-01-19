using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.HTTP
{
    public enum HttpStatusCode
    {
        Ok = 200,
        MovedPermanently = 301,
        Redirect = 307,
        NotFound = 404, 
        ServerError = 500,
    }
}
