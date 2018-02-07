using System;
using System.Threading.Tasks;

namespace Core.Lib.Helper
{
    public class TaskHelper
    {
        public Task Action(Action action) => Task.Run(action);
        public Task Empty<T>() => Task.CompletedTask;
        public Task<T> Func<T>(T target) => Task.FromResult(target);
        public Task<T> Func<T>(Func<T> func) => Task.Run(func);
    }
}
