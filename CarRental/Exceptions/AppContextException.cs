using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Exceptions
{
    public class AppContextException : Exception
    {
        public AppContextException(string msg) : base(msg) { }
    }
}
