using System;
using System.Collections.Generic;
using System.Text;

namespace Validation
{
    public interface IValidatable<T>
    {
        void Validate(IsValid<T> validator);
    }
}
