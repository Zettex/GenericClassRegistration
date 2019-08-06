using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class BaseClass<T> : IBaseClass<T> where T : BaseEntity
    {
        public virtual bool GetFalse()
        {
            return false;
        }

        public virtual bool GetTrue()
        {
            return true;
        }
    }
}