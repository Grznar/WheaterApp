using WheaterApp.Server.Data.IRepositories;
using WheaterApp.Server.Models;

namespace WheaterApp.Server.Data.Repositories
{
    public class ApplicationUserRepositoory : Repository<ApplicationUser>, IApplicationUserRepository
    {

        private readonly ApplicationDbContext _db;

        public ApplicationUserRepositoory(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }




        public void Update(ApplicationUser entity)
        {
            _db.Update(entity);
        }
    }
}
