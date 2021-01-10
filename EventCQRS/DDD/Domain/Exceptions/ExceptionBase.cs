using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
   public class ExceptionBase:Exception
    {
        public ExceptionBase(string message):base(message)
        {

        }
    }
}
