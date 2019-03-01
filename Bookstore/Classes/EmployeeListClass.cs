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
            bool success = false;
            return false;
        }

        public void displayEntireList()
        {
            
        }

        // Initialize entire employee list given data in current Book File 
        public Boolean initializeEntireList()
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;

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
    }
}
