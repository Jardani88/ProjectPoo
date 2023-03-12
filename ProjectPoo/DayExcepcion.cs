﻿using System.Runtime.Serialization;

namespace ProjectPoo
{
    [Serializable]
    internal class DayExcepcion : Exception
    {
        public DayExcepcion()
        {
        }

        public DayExcepcion(string? message) : base(message)
        {
        }

        public DayExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DayExcepcion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}