using WheaterApp.Server.Data.IRepositories;

namespace WheaterApp.Server.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly ApplicationDbContext _db;
        public IApplicationUserRepository Users { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Users = new ApplicationUserRepositoory(_db);
        }

        

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
