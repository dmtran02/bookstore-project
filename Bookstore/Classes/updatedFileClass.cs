using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore.Classes
{
    class UpdatedFileClass
    {
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW;  // Reference variable of type SW
        private int recordWrittenCount;

        // Constructor with file path input
        // Create instance of StreamWriter class (type) and store reference
        public UpdatedFileClass
            (string filePath)
        {
            recordWrittenCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + "Terminate Program.",
                                "Input File Connection Error.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        } // end updatedFileClass Constructor



        // Write a record to the updated file
        public void putNextRecord
            (string record)
        {
            try
            {
                updatedFileSW.WriteLine(record);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IO error in file write. Terminate program.",
                                "File Write Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // end Try
            recordWrittenCount += 1;
        } // end putNextRecord



        // Get value of number of records written
        public int getRecordsWrittenCount()
        {
            return recordWrittenCount;
        } // end getRecordsWritten



        // Close the output (updated) file
        public void closeFile()
        {
            updatedFileSW.Flush();
            updatedFileSW.Close();
        } // end closeFile



        // Rewind the output file
        public void rewindFile()
        {
            recordWrittenCount = 0;
            closeFile();
            updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } // end rewindFile

    } // end UpdatedFile Class
} // end namespace

