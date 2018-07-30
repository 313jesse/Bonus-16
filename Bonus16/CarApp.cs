using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus16
{
    class CarApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cars would you like to enter?");
            int size = int.Parse(Console.ReadLine());

            List<Cars> cars = new List<Cars>();
            // used to add new cars to the list

            while (true)
            #region User Input Car Info
            {
                Cars temp = new Cars();
                Console.WriteLine("Please provide the make");
                temp.MAKE = Console.ReadLine();


                Console.WriteLine("Please provide the car model");
                temp.MODEL = Console.ReadLine();


                Console.WriteLine("Please provide car year");
                temp.YEAR = int.Parse(Console.ReadLine());


                Console.WriteLine("Please provide the MSRP");
                temp.PRICE = int.Parse(Console.ReadLine());

                cars.Add(temp); // add the temp object to cars list

                Console.WriteLine("do you want to add another vehicle?");
                string choice = Console.ReadLine();
                if (choice == "n")
                    break;
                #endregion
            #region Print Each Car Info
            }
            
            foreach (Cars c in cars)
            {

                Console.WriteLine("Make: " + c.MAKE);
                Console.WriteLine("Model: " + c.MODEL);
                Console.WriteLine("Year: " + c.YEAR);
                Console.WriteLine("Price: " + c.PRICE);
                Console.WriteLine("========================");
            }
            #endregion

            #region //Reference Comments//(ignore)
            //REFERENCE COMMENTS:
            //Console.WriteLine(john.FirstName);   // will display          John
            //john.Salary = 50000;
            //john.Salary = john.Salary + 10000;
            //Console.WriteLine(john.Salary);
            //Console.WriteLine(john.SSN); // blank if unassigned, default filled in. 
            //Employee jacob = new Employee();
            //jacob.FirstName = "Jacob";
            //jacob.LastName = "Snover";
            //jacob.Salary = 250000;
            #endregion


        }
    }
}

    

