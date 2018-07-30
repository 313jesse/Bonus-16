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
            private int year;
            private double price;
                          
            public string MAKE
            {
                set { make = value; }
                get { return make; }              
            }

            public string MODEL
            {
                set { model = value; }  
                get { return model; }
            }

            public int YEAR
            {
                set {
                if (!Regex.IsMatch(value.ToString(), @"^\d{4}$"))
                {
                    throw new Exception("Year is not a valid year!");
                }
                else
                {
                    year = value; 
                }
            }
                get { return year; }
                
        }
        
            public double PRICE
            {
                set { price = value; }
                get { return price; }
            }
        #endregion
    }
}
