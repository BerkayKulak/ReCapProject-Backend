using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        // base dediğimiz DataResult
        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }

        public SuccessDataResult(T data):base(data,true)
        {

        }

        public SuccessDataResult(string message):base(default,true,message)// bir şey döndürmek istemiyoruz
        {

        }

        public SuccessDataResult():base(default,true)
        {

        }
    }
}
