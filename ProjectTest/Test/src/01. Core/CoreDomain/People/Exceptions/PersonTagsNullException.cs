using Zamin.Core.Domain.Exceptions;

namespace CoreDomain.People.Exceptions
{
    public class PersonTagsNullException :InvalidEntityStateException
    {
        public PersonTagsNullException(string message, params string[] parameters) : base(message, parameters)
        {
        }
    }
}
