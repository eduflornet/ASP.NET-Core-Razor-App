
namespace Abby.DAL.Repository.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        ICategoryRepository Category { get; }
    }
}
