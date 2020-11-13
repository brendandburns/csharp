using System;
using System.Threading;
using System.Threading.Tasks;

namespace k8s
{
    public class Wait
    {
        public static async Task<T> WaitFor<T>(Func<Task<T>> producer, Predicate<T> test, CancellationToken cancel = default(CancellationToken)) where T : IKubernetesObject
        {
            return await WaitFor(producer, test, TimeSpan.FromSeconds(60), cancel).ConfigureAwait(false);
        }

        public static async Task<T> WaitFor<T>(Func<Task<T>> producer, Predicate<T> test, TimeSpan interval, CancellationToken cancel = default(CancellationToken)) where T : IKubernetesObject
        {
            var val = await producer().ConfigureAwait(false);
            while (!test(val))
            {
                await Task.Delay(interval, cancel).ConfigureAwait(false);
                val = await producer().ConfigureAwait(false);
            }

            return val;
        }
    }
}