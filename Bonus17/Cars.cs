using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Bonus16
{
    class Cars
    {
        #region Publics
        private string make;
            private string model;
            private string year;
            private double price;
                          
            public string MAKE
            {
                set { make = value; }
                get { return make; }              
            }

        internal static void Add(Cars cars)

        {
            throw new NotImplementedException();
        }

        


        public string MODEL
            {
                set { model = value; }  
                get { return model; }
            }

            public string YEAR
            {
                set { year = value;  }
                get { return year; }
                
        }
        
            public double PRICE
            {
                set { price = value; }
                get { return price; }
            }
        #endregion

        //constructor to set default values to NA and zero

        public Cars()
        {
            MAKE = "not assigned";
            MODEL = "not assigned";
            YEAR = "NA";
            PRICE = 0;

        }

        public Cars(string ma, string mo, string ye, double pr)
        {
            MAKE = ma;
            MODEL = mo;
            YEAR = ye;
            PRICE = pr;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Make: {MAKE}, Model: {MODEL}, Year: {YEAR}, Price:${PRICE}" );
        }

        
    }
}
