using System;
using System.Collections.Generic;
using System.Text;
using Zamin.Core.Domain.Exceptions;

namespace CoreDomain.People.Exceptions
{
    public class InvalidFirstNameException : InvalidEntityStateException
    {
        public InvalidFirstNameException(string message, params string[] parameters) : base(message, parameters)
        {
        }
    }
}
