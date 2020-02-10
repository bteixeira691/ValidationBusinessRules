using System;
using System.Collections.Generic;
using System.Text;

namespace Validation
{
    public interface IsValid<T> 
    {
       
        void isValided(T obj);
    }
}
