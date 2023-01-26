namespace DependencyInjection.Services
{
    public class SingletonService : ISingletonService
    {
        Guid id;
        private readonly ITransientService _transientServiceFromConstructor;
        private readonly Func<ITransientService> _transientServiceFactory;
        public SingletonService(
            ITransientService transientService,
            Func<ITransientService> transientServiceFactory)
        {
            _transientServiceFromConstructor = transientService;
            _transientServiceFactory = transientServiceFactory;
        }

        public Guid GetIdFromConstructor()
        {
            return _transientServiceFromConstructor.GetId();
        }

        public Guid GetIdFromFactory()
        {
            var transientServiceFromFactory = _transientServiceFactory();
            return transientServiceFromFactory.GetId();
        }
    }
}
