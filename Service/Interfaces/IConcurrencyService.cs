namespace BlogApp.Service.Interfaces
{
    public interface IConcurrencyService
    {
        SemaphoreSlim SemaphorePerUser(int userId);
    }
}
