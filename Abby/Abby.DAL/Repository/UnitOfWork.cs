using Abby.DAL.Data;
using Abby.DAL.Repository.IRepository;

namespace Abby.DAL.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
