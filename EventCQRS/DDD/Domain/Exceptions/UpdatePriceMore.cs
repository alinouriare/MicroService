using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class UpdatePriceMore : ExceptionBase
    {
        public UpdatePriceMore(string message) : base(message)
        {
        }
    }
}
