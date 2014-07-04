using System;
using System.Collections.Generic;

namespace SimpleServerProto
{
    [Serializable]
    public class ResponseAuthorization
    {
        public bool Error { get; set; }
        public string ErrorMessage { get; set; }
        public uint Money { get; set; }
        public Dictionary<Cookie, uint> Cookies { get; set; }
    }
}
