using System;

namespace SimpleServerProto
{
    [Serializable]
    public class RequestBuyCookie
    {
        public Cookie Cookie { get; set; }
        public uint Quantity { get; set; }
    }
}
