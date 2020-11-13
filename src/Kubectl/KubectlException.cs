using System;

namespace KubectlDotNet
{
    public class KubectlException : Exception
    {
        public KubectlException()
        : base()
        {
        }

        public KubectlException(string msg)
        : base(msg)
        {
        }

        public KubectlException(string msg, Exception ex)
        : base(msg, ex)
        {
        }
    }
}
