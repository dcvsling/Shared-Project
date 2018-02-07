using System;

namespace Core.Lib.Helper
{

    public class FuncHelper
    {
        internal FuncHelper()
        {
        }
        public Func<T> Throw<T>(Exception ex) => () => throw ex;
        public Func<T> Result<T>(T t) => () => t;
        public T Create<T>(T t) => t;
        public Func<T> Factory<T>(Func<T> factory = default)
            where T : class
            => factory ?? Activator.CreateInstance<T>;
    }
}
