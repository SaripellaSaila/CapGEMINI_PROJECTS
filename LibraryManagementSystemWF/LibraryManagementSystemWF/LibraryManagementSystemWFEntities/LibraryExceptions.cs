using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemWFEntities
{
    public class LibraryExceptions : ApplicationException
    {
        public LibraryExceptions() : base()
        {

        }

        public LibraryExceptions(string msg) : base(msg)
        {

        }
        public LibraryExceptions(string msg, Exception InnerException) : base(msg, InnerException)
        {

        }
    }
}
