using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zuber_webapp.Contracts;
using Zuber_webapp.Data;

namespace Zuber_webapp.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        private readonly ApplicationDbContext _db;
        public DriverRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Driver entity)
        {
            _db.Drivers.Add(entity);
            return Save();
        }

        public bool Delete(Driver entity)
        {
            _db.Drivers.Remove(entity);
            return Save();
        }

        public ICollection<Driver> FindAll()
        {
            return _db.Drivers.ToList();
        }

        public Driver FindById(int id)
        {
            var Driver = _db.Drivers.Find(id);
            return Driver;
        }

        public ICollection<Driver> GetTripsByDriver(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Driver entity)
        {
            _db.Drivers.Update(entity);
            return Save(); 
        }
    }
}
