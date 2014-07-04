using System;

namespace SimpleServerProto
{
    [Serializable]
    public class Cookie
    {
        public string Name { get; set; }
        public uint Price { get; set; }
    }
}
