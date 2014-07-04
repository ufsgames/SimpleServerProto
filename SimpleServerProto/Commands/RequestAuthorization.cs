using System;

namespace SimpleServerProto
{
    [Serializable]
    public class RequestAuthorization
    {
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
