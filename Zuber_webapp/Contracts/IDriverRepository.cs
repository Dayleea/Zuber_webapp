using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zuber_webapp.Data;

namespace Zuber_webapp.Contracts
{
    public interface IDriverRepository: IRepositoryBase<Driver> 
    {
        ICollection<Driver> GetTripsByDriver(int id);
    }
}
