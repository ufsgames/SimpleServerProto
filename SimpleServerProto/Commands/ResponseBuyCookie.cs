using System;

namespace SimpleServerProto
{
    [Serializable]
    public class ResponseBuyCookie
    {
        public bool Error { get; set; }
        public string ErrorMessage { get; set; }
        public Cookie Cookie { get; set; }
        public uint Quantity { get; set; }
    }
}
