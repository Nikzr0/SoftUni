using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.HTTP
{
    // An enum of status code
    // There many more status codes out there, those ther are just some examples
    public enum HttpStatusCode
    {
        Ok = 200,
        MovedPermanently = 301,
        Redirect = 307,
        NotFound = 404, 
        ServerError = 500,
    }
}
