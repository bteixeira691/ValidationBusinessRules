using System;
using System.Collections.Generic;
using System.Text;

namespace Validation.Model
{
    public class ObjectForValidation : MasterClass
    {
        public string Name { get; set; }

        public List<string> ErroMessage = new List<string>();

        
    }

}
