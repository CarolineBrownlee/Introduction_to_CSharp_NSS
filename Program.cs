using System;
using System.Collections.Generic;

namespace bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime is the type of the purchaseData variable.
            DateTime purchaseDate = DateTime.Now;

            /*
                string is the type of the lastName variable. It
                tells the compiler that the lastName variable can
                ONLY hold a string value.
            */
            string lastName = "Smith";

            /*
                C# now supports implicitly typing of a variable. The
                type of the variable will be determined, by the
                compiler, at compile time.
            */
            var firstName = "Bill";

            /*
                String interpolation in C# is similar to string interpolation in JavaScript,
                but there is a different syntax.

                An equivalent statement in JavaScript would be:
                console.log(`${firstName} ${lastName} purchased on ${purchaseDate}`);
            */
            Console.WriteLine($"{firstName} {lastName} purchased on {purchaseDate}");

            /*
            C# COLLECTIONS AND LOOPS:

            The C# language has many ways to store a collection of items. You'll quickly see that C# is much more verbose when you write your source code, because the developer needs to provide all of the instructions to the compiler, unlike JavaScript or other dynamically typed languages.

            Not only do you have to say what type the variable is, you also
            have to instantiate that exact same type of object on assignment.
            This may seem redundant, but it's part of the C# language compiler's
            type checking constraints.
            */

            List<string> products = new List<string>() {
                "Motorcycle",
                "Sofa",
                "Sandals",
                "Omega Watch",
                "iPhone"
            };

            /*
            A foreach loop is used to iterate over a collection.

            The code below is roughly equivalent to the following JavaScript:
            products.forEach(product => {
                console.log(product);
            });
            */

            foreach (string product in products)
            {
                Console.WriteLine(product);
            }

            /*
            Like JavaScript, C# has a for() loop

            This code is equivalent to the foreach loop above.
            */

            // for (int i = 0; i < products.Count; i++) {
            //     Console.WriteLine(products[i]);
            // }

            /*
           C# CONDITIONALS:

           Let's display a different message based on on the length of a product.
           */

            foreach (string product in products) {
                if (product.Length < 5)
                {
                    Console.WriteLine($"{product} has a short name");
                }
                else if (product.Length < 10)
                {
                    Console.WriteLine($"{product} has a medium-sized name");
                }
                else
                {
                    Console.WriteLine($"{product} has a long name");
                }
            }
        }
    }
}

