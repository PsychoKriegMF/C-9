using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_9
{
    public class UnderRageException : Exception
    {
        public UnderRageException(string message) : base(message) { }
    }
}
