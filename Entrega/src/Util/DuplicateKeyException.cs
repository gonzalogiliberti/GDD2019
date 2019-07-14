using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Util
{
    class DuplicateKeyException : Exception
    {
        public DuplicateKeyException() { }


        public DuplicateKeyException(string message) { }
    }
}
