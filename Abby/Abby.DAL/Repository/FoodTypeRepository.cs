using Abby.DAL.Data;
using Abby.DAL.Repository.IRepository;
using Abby.Models;

namespace Abby.DAL.Repository
{
    public class FoodTypeRepository : Repository<FoodType>, IFoodTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public FoodTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(FoodType foodType)
        {
            var objFromDb = _db.FoodType.FirstOrDefault(u => u.Id == foodType.Id);
            objFromDb.Name = foodType.Name;
        }
    }
}