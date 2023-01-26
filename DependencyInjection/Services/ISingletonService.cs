namespace DependencyInjection.Services
{
    public interface ISingletonService
    {
        Guid GetIdFromProvider();
        Guid GetIdFromConstructor();
    }
}
