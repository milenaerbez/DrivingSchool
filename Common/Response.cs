using System;

namespace Common
{
    [Serializable]
    public class Response
    {
        public object ResponseObj { get; set; } 
        public string Message { get; set; }

    }
}
