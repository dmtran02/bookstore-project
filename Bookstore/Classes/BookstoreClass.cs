// BookStore Class 
// Contains constants, properties and other data related to the Bookstore
//     Frank Friedman
//     CIS 3309

//     Created on January 13 by FLF
//     Modified ... January 30, 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore.Classes
{
    class BookStoreClass
    {
        // Books and the EmployeeList and all the text files belong to the Bookstore
        public BookClass Book = new BookClass();
        public EmployeeListClass EmployeeList = new EmployeeListClass();

        // The Files the Bookstore Owns
        private static string currentBookFilePath = "currentBookFile.txt";
        private static string updatedBookFilePath = "updatedBookFile.txt";
        private static string currentEmployeeFilePath = "currentEmployeeFile.txt";
        private static string updatedEmployeeFilePath = "updatedEmployeeFile.txt";

        public static currentFileClass currentBookFile = new currentFileClass(currentBookFilePath);
        public static UpdatedFileClass updatedBookFile = new UpdatedFileClass(updatedBookFilePath);
        public static currentFileClass currentEmployeeFile = new currentFileClass(currentEmployeeFilePath);
        public static UpdatedFileClass updatedEmployeeFile = new UpdatedFileClass(updatedEmployeeFilePath);

        // Bookstore parameters (Named constants defined by the Bookstore)
        private int hiddenAccessIDLength = 5;   // Length of AccessNet ID
        private int hiddenISBNLeftLength = 3;   // Length of left part of ISBN
        private int hiddenISBNRightLength = 3;  // Length of right part of ISBN
        // Number of attempts BookStore allows a user before terminating an inventory update session
        private int hiddenTryCountMax = 3;



        // Parameterless Constructor for the BookStore Class ...
        public BookStoreClass()
        {

        }  // end Parameterless Constructor



        // ***** Properties
        public int accessIDLength
        {
            get
            {
                return hiddenAccessIDLength;
            } // end Get
        } // end Property



        public int ISBNLeftLength
        {
            get
            {
                return hiddenISBNLeftLength;
            } // end Get
        } // end Property ccessIDLength



        public int ISBNRightLength
        {
            get
            {
                return hiddenISBNRightLength;
            } // end Get
        } // end Property ISBNRightLength



        public int tryCountMax
        {
            get
            {
                return hiddenTryCountMax;
            } // end Get
        } // end Property tryCountMax

        // ***** End of Properties



        // Find Employee in Employee List
        // Returns a reference to the employee found and (through an argument) returns true or false
        //public EmployeeClass findEmployee
        public bool findEmployee
            (int ID)              // IN: employee ID to be found   
        {
            // EmployeeClass emp;    // reference to current Employee being checked for ID
            //if ((emp = EmployeeList.findEmployeeInList(ID)) != null)
            //{
            //    found = true;
            //}
            //else
            //    found = false;
            //return found;
            return EmployeeList.findEmployeeInList(ID);

        }  // end findEmployee



        // Displays the list of employees (After they were written to the Employee File)
        public void writeEntireEmployeeList()
        {
            EmployeeList.displayEntireList();
        }   // end writeEntireEmploeeList



        // Find and save Book record given the entered ISBN
        // Returns: a string from the currentBookFile or null and (through an argument) true or false
        public string findAndSaveBook(
            string ISBN,
            out Boolean found)
        {
            string nextRecord;
            Boolean isEndOfFile = true;

            nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
            found = false;
            while (!isEndOfFile)
            {
                if (Book.bookMatch(ISBN, nextRecord))
                {
                    found = true;
                    return (nextRecord);
                }
                else
                {
                    updatedBookFile.putNextRecord(nextRecord);
                    Book.displayBookRecord(nextRecord);
                    nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
                } // end If
            } //end While

            return (nextRecord);
        } //end findAndSaveBook



        // Check for duplicate record during an add operation
        // Returns: true if there is a match (meaning this ISBN is in use).  Otherwise returns false.
        public Boolean checkForDuplicateRecord
            (string ISBNtoBeAdded)  // IN: ISBN for the book to be added
        {
            Boolean found = false;

            findAndSaveBook(ISBNtoBeAdded, out found);

            if (found == true)
            {
                // rewind current book file
                currentBookFile.rewindFile();
            }
            return found;
        }   // end checkForDuplicateRecord



        // Writes a single record (such as a modified record) to the updated file
        // Returns: (none)
        public void writeOneRecord(string record)
        {
            updatedBookFile.putNextRecord(record);
            Book.displayBookRecord(record);
        }  // end writeOneRecord



        // Copies remaining records from currentFile to updatedFile.
        // Returns: (none)
        public void copyRemainingRecords()
        {
            Boolean isEndOfFile = false;
            string nextRecord;

            nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                updatedBookFile.putNextRecord(nextRecord);
                Book.displayBookRecord(nextRecord);
                nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
            } // end While

            MessageBox.Show("All records in original file have been copied." + "\n"
                + "The number of records read is: " + currentBookFile.getRecordsReadCount().ToString() + "\n"
                + "The number of records written is: " + updatedBookFile.getRecordsWrittenCount().ToString(),
                "All records processed.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        } // end copyRemaingRecords



        // Rewind all test files
        public void rewindFiles()
        {
            currentBookFile.rewindFile();
            updatedBookFile.rewindFile();
            currentEmployeeFile.rewindFile();
            updatedEmployeeFile.rewindFile();
        }  // end rewindFiles



        // Close all text files
        public void closeFiles()
        {
            currentBookFile.closeFile();
            updatedBookFile.closeFile();
            currentEmployeeFile.closeFile();
            updatedEmployeeFile.closeFile();
        }  // end closeFiles
    } // end BookStore Class
}  // end Namespace
