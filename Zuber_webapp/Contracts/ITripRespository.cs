using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zuber_webapp.Data;

namespace Zuber_webapp.Contracts
{
    interface ITripRespository: IRepositoryBase<Trip>
    {

        ICollection<Trip> GetDriverByTrip(int id);
    }
}
