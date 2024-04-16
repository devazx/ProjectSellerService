using System;

namespace ProjectSellerService.Services.Exception
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {

        }
    }
}
