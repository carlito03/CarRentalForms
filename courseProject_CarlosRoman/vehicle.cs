using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject_CarlosRoman
{
    class vehicle
    {
        #region Fields
        private string company;
        private string model;
        #endregion endFields 

        #region constructors 
        public vehicle()
        {

        }


        public vehicle(string company, string model)
        {

            this.company = company;
            this.model = model;

        }

        #endregion constructors 

        #region properties 

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }

    }

        public string Company { get; set; }
        #endregion endproperties 

        #region methods

        public override string ToString()
        {
            return "Model: " + model.ToString() + "\n" +
                  "Make: " + company.ToString();
        }

        #endregion endMethods

    }
}
