using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool succes,string messages):this(succes)
        {
            Messages = messages;
        }
        public Result(bool succes)
        {
            Success = succes;
        }
        public bool Success { get; }

        public string Messages { get; }
    }
}
