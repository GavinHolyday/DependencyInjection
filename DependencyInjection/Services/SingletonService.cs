namespace DependencyInjection.Services
{
    public class SingletonService : ISingletonService
    {
        Guid id;
        private readonly IServiceProvider _serviceProvider;
        private readonly ITransientService _transientServiceFromConstructor;
        public SingletonService(
            ITransientService transientService,
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _transientServiceFromConstructor = transientService;
        }
        public Guid GetIdFromProvider()
        {
            var transientServiceFromProvider = _serviceProvider.GetService<ITransientService>();
            return transientServiceFromProvider.GetId();
        }

        public Guid GetIdFromConstructor()
        {
            return _transientServiceFromConstructor.GetId();
        }
    }
}
