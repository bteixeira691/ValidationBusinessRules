using System;
using System.Collections.Generic;
using System.Text;
using Validation.Model;

namespace Validation.Validation
{
    public class Valid1 : IsValid<ObjectForValidation>
    {
      
        public void isValided(ObjectForValidation paramenterValid)
        {
            if (paramenterValid.Name == "valid")
            {
                Console.WriteLine("{0} is valid", paramenterValid.GetType());
                return;
            }
            paramenterValid.ErroMessage.Add("Valid1 invalid");
            Console.WriteLine("{0} is not valid", paramenterValid.GetType());
        }

     
    }
}
