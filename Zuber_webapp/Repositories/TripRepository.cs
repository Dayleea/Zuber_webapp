using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zuber_webapp.Contracts;
using Zuber_webapp.Data;

namespace Zuber_webapp.Repositories
{
    public class TripRepository : ITripRespository
    {
        private readonly ApplicationDbContext _db;
        public TripRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Trip entity)
        {
            _db.Trips.Add(entity);
            return Save();


        }

        public bool Delete(Trip entity)
        {
            _db.Trips.Remove(entity);
            return Save();


        }

        public ICollection<Trip> FindAll()
        {
            return _db.Trips.ToList();
        }

        public Trip FindById(int id)
        {
            var Trip = _db.Trips.Find(id);
            return Trip;


        }

        public ICollection<Trip> GetPersonByTrip(int id)
        {
            ;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;

        }

        public bool Update(Trip entity)
        {
            _db.Trips.Update(entity);
            return Save();

        }
    }
}
