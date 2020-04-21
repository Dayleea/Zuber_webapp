using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zuber_webapp.Contracts;
using Zuber_webapp.Data;

namespace Zuber_webapp.Repositories
{
    public class CarTypeRepository : ICarTypeRepository
        
    {
        private readonly ApplicationDbContext _db; 
        public CarTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public bool Create(CarType entity)
        {

            _db.CarTypes.Add(entity);
            return Save();
        }

        public bool Delete(CarType entity)
        {
            _db.CarTypes.Remove(entity);
            return Save();
        }

        public ICollection<CarType> FindAll()
        {
            return _db.CarTypes.ToList();
        
        }

        public CarType FindById(int id)
        {
           var Cartype = _db.CarTypes.Find(id);
            return Cartype; 
                
        }

        public ICollection<CarType> GetDriversByCarType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0 ;
        }

        public bool Update(CarType entity)
        {
            _db.CarTypes.Update(entity);
            return Save(); 
        }
    }
}
