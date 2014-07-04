using System;
using System.Collections.Generic;

namespace SimpleServerProto
{
    [Serializable]
    public class ResponseCookieList
    {
        public List<Cookie> Cookies { get; set; }
    }
}
