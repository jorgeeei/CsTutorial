using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    //public accessibility 
    //callable from any other component
    public class Customer
    {
        // adding properties to customer class
        // the class should encapsulate the data
        // by defining a private backing field
        private string _lastName;

        // if this were internal, then it would only be accessible
        // to other component in the Business Layer class (AKA same namespace)
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        // example of auto-implemented properties
        // C# automatically creates the backing field
        // only use if you don't need any code in getter/setter
        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!String.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName;
            }
        }

        public static int InstanceCount { get; set; }
    }
}
