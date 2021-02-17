using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qiang_Zhang_SD6503_Assignment_1
{
    //This class used to store staff data about objects
    public class Staff
    {
        //private variables
        private string staffId;
        private string staffName;
        private string dateofBirth;
        private string email;
        private string annualSalary;
        private string position;
        private string department;


        public string StaffId   // property
        {
            get { return staffId; }   // get method
            set { staffId = value; }  // set method
        }

        public string StaffName   // property
        {
            get { return staffName; }   // get method
            set { staffName = value; }  // set method
        }

        public string DateofBirth   // property
        {
            get { return dateofBirth; }   // get method
            set { dateofBirth = value; }  // set method
        }

        public string Email   // property
        {
            get { return email; }   // get method
            set { email = value; }  // set method
        }

        public string AnnualSalary   // property
        {
            get { return annualSalary; }   // get method
            set { annualSalary = value; }  // set method
        }

        public string Position   // property
        {
            get { return position; }   // get method
            set { position = value; }  // set method
        }

        public string Department   // property
        {
            get { return department; }   // get method
            set { department = value; }  // set method
        }

        //constructor with default values
        public Staff()
        {
            StaffId = "NA";
            StaffName = "NA";
            DateofBirth = "NA";
            Email = "NA";
            AnnualSalary = "NA";
            Position = "NA";
            Department = "NA";
        }
        //override the ToString() method to display staff information
        public override string ToString()
        {
            return StaffId + "," + StaffName + ","+DateofBirth + ","+Email + ","+AnnualSalary + ","+Position + ","+Department; 
        }

    }
}
