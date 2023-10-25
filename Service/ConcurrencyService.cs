using BlogApp.Service.Interfaces;
using System.Collections.Concurrent;

namespace BlogApp.Service
{
    public class ConcurrencyService : IConcurrencyService
    {
        public static ConcurrentDictionary<int, SemaphoreSlim> Semaphors = new ConcurrentDictionary<int, SemaphoreSlim>();

        public SemaphoreSlim SemaphorePerUser(int userId)
        {
            return Semaphors.GetOrAdd(userId, new SemaphoreSlim(1, 1));
        }
    }
}
