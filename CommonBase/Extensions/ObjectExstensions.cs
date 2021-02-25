//@BaseCode

using System;

namespace CommonBase.Extensions
{
    public static class ObjectExstensions
    {
        public static void CheckArgument(this object source, string argName)
        {
            if (source == null)
                throw new ArgumentNullException(argName);
        }
    }
}