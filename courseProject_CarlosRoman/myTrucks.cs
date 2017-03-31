using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject_CarlosRoman
{
    class myTrucks : myCars
    {
        private string torque;

        public myTrucks(string model, string company, string miles, string licensePlate, string type, string otherFeatures, string returnDate) : base(model, company, miles, licensePlate, type, otherFeatures, returnDate)
        {
        }
    }
}
