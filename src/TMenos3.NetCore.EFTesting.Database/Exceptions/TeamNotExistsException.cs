﻿using System;
using System.Runtime.Serialization;

namespace TMenos3.NetCore.EFTesting.Database.Exceptions
{
    public class TeamNotExistsException : Exception
    {
        public TeamNotExistsException()
        {
        }

        public TeamNotExistsException(string message) 
            : base(message)
        {
        }

        public TeamNotExistsException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        protected TeamNotExistsException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}
