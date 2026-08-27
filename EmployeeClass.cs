using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Checkout_System
{
    public class EmployeeClass 
    {
        protected int employeeID;
        protected string password;
        protected string firstName;
        protected string lastName;
       

        public EmployeeClass()
        {
            employeeID = 0000000;
            password = "N/A";
            firstName = "N/A";
            lastName = "N/A";
        }

        public EmployeeClass(int employeeID, string password, string firstName, string lastName)
        {
            this.employeeID = employeeID;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            
        }

        public override string ToString()
        {
            return EmployeeID + "," + Password;
        }

        public int EmployeeID
        {
            set
            {
                if (value == 0)
                {
                    employeeID = value;
                }
                else
                {
                    employeeID = 0000000;
                }
            }
            get { return employeeID; }
            
        }

        public string Password
        {
            set
            {
                if (value.Length > 1)
                {
                    password = value;
                }
                else
                {
                    password = "N/A";
                }
            }
            get { return password; }
        }

        public string FirstName
        {
            set
            {
                if (value.Length > 1)
                {
                    firstName = value;
                }
                else
                {
                    firstName = "N/A";
                }
            }
            get { return firstName; }
        }

        public string LastName
        {
            set
            {
                if (value.Length > 1)
                {
                    lastName = value;
                }
                else
                {
                    lastName = "N/A";
                }
            }
            get { return lastName; }
        }

    }
}
