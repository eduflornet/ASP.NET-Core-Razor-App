using Abby.Models;

namespace Abby.DAL.Repository.IRepository
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {
        void Update(MenuItem obj);

    }
}
