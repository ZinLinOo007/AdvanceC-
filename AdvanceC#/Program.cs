using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTyping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit type

            var firstName = "John";
            var  num = 13;
            object obj = "Hello World";

            //explicit type

            string name = "John Doe";

            /*
             * There are several restrictions when using ‘var’ such as:
             * Only for variables defined in a method body
             * Not used as a return type
             * Cannot be set to null (i.e. var test = null;is not valid)
             * Must be initialised (i.e. var test; is not valid either)
             * 
             */

            //Boxing and Unboxing
            /*
             * from value type to object type call boxing
             * from object type to value type call unboxing
             */
            int age = 21;
            object obj1 = age;//Boxing

            object obj2 = 20;
            int age2 =(int) obj2;//Unboxing

            //Anonymous Type
            /* 
             * * Anonymous types provide a convenient way to encapsulate a set of read-only properties 
            * into a single object without having to explicitly define a type first.
            */
            var person = new { firstName = "John", lastName = "Doe", Age = 23 };


            //Dynamic Type
            /*
             * Once compiled, a ‘dynamic’ is usually represented as a System.
             * Object(but without the compile time checks!)
             */
            dynamic dy = "Hello World!";

        }
    }
}
