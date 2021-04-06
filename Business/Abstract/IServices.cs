using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IServices<T> where T : class
    {
        List<T> GetAll();



    }
}