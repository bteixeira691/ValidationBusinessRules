using System;
using System.Collections.Generic;
using System.Text;

namespace Validation.Model
{
    public class ObjectForValidation : MasterClass, IValidatable<ObjectForValidation>
    {
        public string Name { get; set; }

        public List<string> ErroMessage = new List<string>();

        public void Validate(IsValid<ObjectForValidation> validator)
        {
            validator.isValided(this);
        }
    }

}
