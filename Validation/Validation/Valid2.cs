using System;
using System.Collections.Generic;
using System.Text;
using Validation.Model;

namespace Validation.Validation
{
    public class Valid2 : IsValid<ObjectForValidation>
    {
      
        public void isValided(ObjectForValidation paramenterValid)
        {
            if (paramenterValid.Name == "valid2")
            {
                Console.WriteLine("{0} is valid", paramenterValid.GetType());
                return;
            }
            paramenterValid.ErroMessage.Add("Valid2 invalid");
            Console.WriteLine("{0} is not valid", paramenterValid.GetType());
        }
    }
}
