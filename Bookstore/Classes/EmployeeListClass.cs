using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore.Classes
{
    class EmployeeListClass
    {
        private EmployeeClass Employee = new EmployeeClass();
        private int index;

        private List<EmployeeClass> InternalList;

        public EmployeeListClass()
        {
            InternalList = new List<EmployeeClass>(4);
        }

        public bool findEmployeeInList(int ID)
        {
            Boolean success = false;
            while(success == false && index < InternalList.Count)
            {
                if(InternalList[index].checkEmployeeID(ID) == true)
                {
                    success = true;
                    return true;
                }
                else
                {
                    index++;
                }
            }
            index = 0;
            return false;
        }

        public void displayEntireList()
        {
            foreach (EmployeeClass emp in InternalList)
            {
                string s = emp.createStringToWrite();
                BookStoreClass.updatedEmployeeFile.putNextRecord(s);

            }  // end foreach
            return;
        }  // end displayEntireList

    // Initialize entire employee list given data in current Book File 
    public Boolean initializeEntireList()
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;
            // int recordIndex = 0;

            nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countProcessedRecords++;
                EmployeeClass emp = new EmployeeClass();
                success = emp.createEmployeeObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                       ("Unable to create an Employee Object.  Employee list not created.",
                        "Employee List Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                InternalList.Add(emp);
                nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            } //end While
            displayEntireList();

            if (countProcessedRecords > 0)
                return true;
            else
                return false;
        }  // end initializeEntireList

        public Boolean verifyPin(int pin)
        {
            if (InternalList[index].verifyPIN(pin) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
