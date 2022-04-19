using System;

namespace lab7
{
    public class PriceException : Exception
    {
        public PriceException(string message) : base(message) {}
    }

    public class NullReferenceException: Exception
    {
        NullReferenceException(string message) : base(message) {}
    }

    public class ServiceLifeException : Exception
    {
        public ServiceLifeException(string message) : base(message) {}
    }
}