using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus16
{
    class UsedCar : Cars
    {
        private double mileage;
        public double MILEAGE
        {
            set { mileage = value; }
            get { return mileage; }
        }
        public UsedCar() : base()
        {
            mileage = 1000;
        }

        public UsedCar(string ma, string mo, string ye, double pr, double mi) :
            base(ma, mo, ye, pr)
        {
            MILEAGE = mi;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
        }
  

    }
}
