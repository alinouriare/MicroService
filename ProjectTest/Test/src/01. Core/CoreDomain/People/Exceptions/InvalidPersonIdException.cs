using Zamin.Core.Domain.Exceptions;

namespace CoreDomain.People.Exceptions
{
    public class InvalidPersonIdException : InvalidEntityStateException
    {
        public InvalidPersonIdException(string message, params string[] parameters) : base(message, parameters)
        {
        }
    }
}
