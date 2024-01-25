using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndGenException
{
    internal class ProgramLog
    {
        FileStream logFile = null;
        public void OpenLog(FileInfo filName, FileMode mode) { }
        public void WriteLog()
        {
            if (!logFile.CanWrite)
            {
                throw new InvalidOperationException("Logfile cannot be read-only");
            }
        }
    }
}
