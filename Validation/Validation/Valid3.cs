using System;
using System.Collections.Generic;
using System.Text;
using Validation.Model;

namespace Validation.Validation
{
    public class Valid3 : IsValid<ObjectForValidation>
    {
     
        public void isValided(ObjectForValidation paramenterValid)
        {
            if (paramenterValid.Name == "valid3")
            {
                Console.WriteLine("{0} is valid", paramenterValid.GetType());
                return;
            }
            paramenterValid.ErroMessage.Add("Valid3 invalid");
            Console.WriteLine("{0} is not valid", paramenterValid.GetType());
        }
    }
}
