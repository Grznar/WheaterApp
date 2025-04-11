using WheaterApp.Server.Models;

namespace WheaterApp.Server.Data.IRepositories
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        

        void Update(ApplicationUser entity);         
    }
}

