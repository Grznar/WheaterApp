namespace WheaterApp.Server.Data.IRepositories
{
    public interface IUnitOfWork
    {
        public IApplicationUserRepository Users { get; }
        void Save();
    }
}
