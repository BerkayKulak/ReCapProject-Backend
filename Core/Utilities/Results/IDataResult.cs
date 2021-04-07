using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get;  }// Resulttaki olanlar var bir de Bu ifade var T Data ifadesi


    }
}
