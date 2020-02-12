using System;
using System.Collections.Generic;
using Validation.Model;
using Validation.Validation;

namespace Validation
{
    class Program
    {

        static void Main(string[] args)
        {
            ObjectForValidation obj = new ObjectForValidation
            {
                Name = "valid"
            };


            Execut(obj);
            Console.ReadLine();
        }


        public static void Execut(MasterClass obj)
        {
            if (obj is ObjectForValidation)
            {
                List<IsValid<ObjectForValidation>> list = new List<IsValid<ObjectForValidation>>();
                list.Add(new Valid1());
                list.Add(new Valid2());
                list.Add(new Valid3());


                var ObjectForValidation = (ObjectForValidation)obj;

                foreach (var item in list)
                {
                    item.isValided(ObjectForValidation);
                }

                foreach (var item in ObjectForValidation.ErroMessage)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
