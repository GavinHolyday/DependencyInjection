namespace DependencyInjection.Services
{
    public interface ISingletonService
    {
        Guid GetIdFromFactory();
        Guid GetIdFromConstructor();
    }
}
