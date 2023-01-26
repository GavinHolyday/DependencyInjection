namespace DependencyInjection.Services
{
    public class TransientService : ITransientService
    {
        Guid id;
        private readonly ITransientService _transientService;
        public TransientService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetId()
        {
            return id;
        }
    }
}
