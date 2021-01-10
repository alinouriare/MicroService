using Zamin.Core.Domain.Exceptions;

namespace CoreDomain.People.Exceptions
{
    public class InvalidLastNameException : InvalidEntityStateException
    {
        public InvalidLastNameException(string message, params string[] parameters) : base(message, parameters)
        {
        }
    }
}
