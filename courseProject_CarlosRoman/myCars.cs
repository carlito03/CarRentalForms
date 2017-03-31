//This class directly inherits from Vehicle class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject_CarlosRoman
{
    class myCars : vehicle
    {
        private string miles;
        private string licensePlate;
        private string type;
        private string otherFeatures;
        private string returnDate;

    public myCars( string model, string company, string miles, string licensePlate, string type, string otherFeatures, string returnDate)
        {
            this.Model = model;
            this.Company = company;
            this.miles = miles;
            this.licensePlate = licensePlate;
            this.type = type;
            this.otherFeatures = otherFeatures;
            this.returnDate = returnDate;


        }

       

        public string displayInfo()
        {
            return "Model: " + this.Model.ToString() + "\n" +
                  "Company: " + Company.ToString() + "\n" +
                   "Miles: " + miles.ToString() + "\n" +
                   "License Plate: " + licensePlate.ToString() + "\n" +
                   "Vehicle Type: " + type.ToString() + "\n" +
                   "Return Delivery date:" + returnDate.ToString();


        }

    }
}
