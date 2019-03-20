using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore.Classes
{
    class EmployeeClass
    {
        private string[] employeeArray;

        private int accessID;
        private string fullName;
        private int PIN;
        private decimal salary;
        private DateTime lastAccessDate;

        private int hiddenAccessID;
        private string hiddenName;
        private int hiddenPIN;
        private decimal hiddenAnnualPay;
        private DateTime hiddenLastDateOfAccess;

        private int validAccessIDLength = 5;
        private int validPINLength = 4;

        
        public EmployeeClass(int empAccessID, string empFullName, int empPIN, decimal empSalary, DateTime empLastAccessDate)
        {
            accessID = empAccessID;
            fullName = empFullName;
            PIN = empPIN;
            salary = empSalary;
            lastAccessDate = empLastAccessDate;
        }
        
        public EmployeeClass()
        {
            accessID = 1;
            fullName = "";
            PIN = 1;
            salary = 1;
            lastAccessDate = DateTime.Parse("1/1/1111");
        }

        /*
         * createEmployeeObject – Takes a string from the Employee Text File, splits it into 5 components, 
         * creates an Employee object from this string and adds it to the EmployeeList Class (described next).  
         * All 5 elements from the Text File must be validated here.
         */

        public Boolean createEmployeeObject(string s)  // IN: string from the Employee Text File
        {

            EmployeeClass thisEmployee = this;
            string[] holder = s.Split('*');
            string[] employeeString = new string[holder.Length];
            for(int j = 0; j < holder.Length; j++)
            {
                string trimmer = holder[j].Trim();
                employeeString[j] = trimmer;
            }
            int i;

            int employeeStringSize = employeeString.GetLength(0);

            // Convert AccessID to an integer of required length
            if (employeeString[0].Length != validAccessIDLength)
            {
                MessageBox.Show(employeeString[0]
                    + ": AccessID string is not exactly 5 characters. Employee File Corrupt. Execution Terminated.",
                      "AccessID in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            try
            {
                hiddenAccessID = Convert.ToInt32(employeeString[0]);
                accessID = hiddenAccessID;
                //Console.WriteLine("AccessID: " + thisEmployee.accessID);
            }
            catch
            {
                MessageBox.Show(employeeString[0]
                    + " AccessID string is not a valid integer. Employee File Corrupt. Execution Terminated.",
                      "AccessID in Employee File Invalid",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Name string to string (no conversion)
            hiddenName = employeeString[1];
            if (hiddenName == " " || hiddenName == "")
            {
                MessageBox.Show(hiddenName
                    + ": Name string is empty or Blank. Employee File Corrupt. Execution Terminated.",
                      "Name in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
            {
                fullName = hiddenName;
                //Console.WriteLine("Name: " + thisEmployee.fullName);
            }

            // Convert Pin to an integer of required length
            if (employeeString[2].Length != validPINLength)
            {
                MessageBox.Show(employeeString[2]
                    + ": Pin string is not exactly 4 characters. Employee File Corrupt. Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            try
            {
                hiddenPIN = Convert.ToInt32(employeeString[2]);
                PIN = hiddenPIN;
                //Console.WriteLine("PIN: " + thisEmployee.PIN);
            }
            catch
            {
                MessageBox.Show(employeeString[2]
                    + ": Pin string is empty or Blank. Employee File Corrupt.  Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert annualPay to a positive decimal
            try
            {
                hiddenAnnualPay = Convert.ToDecimal(employeeString[3].Replace(",",
                    "").Replace("$", ""));
                salary = hiddenAnnualPay;
                //Console.WriteLine("Salary: " + thisEmployee.salary);
            }
            catch
            {
                MessageBox.Show(employeeString[3]
                    + ": Annual Pay string is not a valid decimal. Employee File Corrupt. Execution Terminated.",
                      "Annual pay in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert last Date of Access to a date
            try
            {
                hiddenLastDateOfAccess = DateTime.Parse(employeeString[4]);
                lastAccessDate = hiddenLastDateOfAccess;
                //Console.WriteLine("Last Access Date: " + thisEmployee.lastAccessDate);
            }
            catch
            {
                MessageBox.Show(employeeString[4]
                    + ": Date of Last Access string is not a valid date. Employee File Corrupt.  Execution Terminated.",
                      "Date of last access in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // All data valid
            employeeArray = employeeString;
            return (true);
        }  // end createEmployeeObject


        /*
         * checkEmployeeID – Compares the Employee Access ID entered by the user to the Access ID in a list element.  
         *  -If no match, ask for re-entry.  
         *  -If there is a match we can then move on to …
         */

        public bool checkEmployeeID(int ID)
        {
            if (employeeArray.Contains(ID.ToString()))
            {
                return true;
            }
            return false;
        }

        /*
         * createStringToDisplay – converts Employee attributes to a string suitable for display in a Message Box
         */

        public string createStringToDisplay()
        {
            string result = "";
            return result;
        }

        /*
         * updateEmployeeTransactionDate – updates the Last Date of Access for an Employee to the current date
         */

        public string updateTransactionDate()
        {
            string result = "";
            return result;
        }

        /*
         * verifyPin – given the Pin entered by the Employee, 
         * checks to see if it matches the Pin corresponding to the Access ID entered by the user. 
         */

        public bool verifyPIN(int PIN)
        {

            if((PIN.ToString().Length > validPINLength) || PIN.ToString().Length < validPINLength)
            {
                MessageBox.Show("Your PIN entry is incorrect. Please try again.", "Incorrect PIN Entry");
            }
            else
            {
                if(this.PIN == PIN)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Please enter your valid PIN.", "Invalid PIN Detected");
                    return false;
                }
            }
            return false;
        }

        // Creates a string to write to the updated Employee File
        // Returns: string to be written
        public string createStringToWrite()
        {
            string decimalAsString = String.Format("{0:c}", hiddenAnnualPay);
            string s = hiddenAccessID.ToString() + " * " + hiddenName + " * " + hiddenPIN.ToString()
                       + " * " + decimalAsString + " * " + hiddenLastDateOfAccess.ToString();
            /*
            MessageBox.Show(hiddenAccessID.ToString() + "\r\n" + hiddenName + "\r\n" + hiddenPIN.ToString() +
                            "\r\n" + decimalAsString + "\r\n" + hiddenLastDateOfAccess.ToString(),
                            "String Written to Updated Employee File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            */
            return s;
        }  // end createStringToWrite

    }
}
