using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus16
{
    class CarApp
    {
        static void Main(string[] args)
        {
            Car1 c1 = new Car1("Chevy", "Equanox", "2015", 20000);
            Console.WriteLine("How many cars would you like to enter?");
            int size = int.Parse(Console.ReadLine());

            List<Cars> cars = new List<Cars>();

            Cars.Add(new Cars() { MAKE = "Chevy", MODEL = "Equanox", YEAR = "2000", PRICE = 2599 });
            Cars.Add(new Cars() { MAKE = "Ford", MODEL = "Edge", YEAR = "2020", PRICE = 2599 });
            Cars.Add(new Cars() { MAKE = "GM", MODEL = "Terrain", YEAR = "1998", PRICE = 2599 });
           UsedCar.Add(new UsedCar() { MAKE = "Plymouth", MODEL = "Acclaim", YEAR = "1934", PRICE = 2599, MILEAGE = 343000});
            UsedCar.Add(new UsedCar() { MAKE = "Jeep", MODEL = "Wrangler", YEAR = "1994", PRICE = 2599, MILEAGE = 145000 });
            UsedCar.Add(new UsedCar() { MAKE = "Saturn", MODEL = "SL1", YEAR = "1999", PRICE = 2599, MILEAGE = 237000 });
            // used to add new cars to the list

            while (true)
            #region User Input Car Info
            {
                //Cars temp = new Cars();
                Console.WriteLine("Please provide the make");
                string MAKE = Console.ReadLine();


                Console.WriteLine("Please provide the car model");
                string MODEL = Console.ReadLine();


                Console.WriteLine("Please provide car year");
                string YEAR = (Console.ReadLine());


                Console.WriteLine("Please provide the MSRP");
                int PRICE = int.Parse(Console.ReadLine());

                Cars temp = new Cars (MAKE, MODEL, YEAR, PRICE);  ////practice this ***************************

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
                Console.WriteLine("Price:" + c.PRICE);
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

    

