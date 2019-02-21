using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Classes
{
    class UpdatedFileClass
    {
        private string updatedBookFilePath;

        public UpdatedFileClass(string updatedBookFilePath)
        {
            this.updatedBookFilePath = updatedBookFilePath;
        }

        public void putNextRecord(string s)
        {

        }

        public int getRecordsWrittenCount()
        {
            int i = 0;

            return i;
        }

        public void rewindFile()
        {

        }

        public void closeFile()
        {

        }
    }
}
