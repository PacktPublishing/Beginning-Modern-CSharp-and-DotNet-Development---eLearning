using System;
namespace Packt.CS7
{
    // Exercise: Inherit from an exception
    public class PersonException : Exception
    {
        public PersonException() : base() { }
        public PersonException(string message) :
        base(message)
        { }
        public PersonException(string message,
        Exception innerException) : base(message,
        innerException)
        { }
    }
}