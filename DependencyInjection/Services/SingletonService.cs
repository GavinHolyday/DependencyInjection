namespace DependencyInjection.Services
{
    public class SingletonService : ISingletonService
    {
        Guid id;
        private readonly IServiceProvider _serviceProvider;
        public SingletonService(ITransientService transientService, IServiceProvider serviceProvider)
        {
            id = Guid.NewGuid();
            _serviceProvider = serviceProvider;
        }
        public Guid GetId()
        {
            var transientService = _serviceProvider.GetService<ITransientService>();
            return transientService.GetId();
        }
    }
}
