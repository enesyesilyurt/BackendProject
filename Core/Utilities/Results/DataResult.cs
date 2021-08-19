using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T>:Result,IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T data,bool succes,string messages):base(succes,messages)
        {
            Data = data;
        }
        public DataResult(T data,bool succes):base(succes)
        {
            Data = data;
        }

        
    }
}
