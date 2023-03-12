using System.Runtime.Serialization;

namespace ProjectPoo
{
    [Serializable]
    internal class MontExeption : Exception
    {
        public MontExeption()
        {
        }

        public MontExeption(string? message) : base(message)
        {
        }

        public MontExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MontExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}