using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zuber_webapp.Data;

namespace Zuber_webapp.Contracts
{
    public interface ICarTypeRepository: IRepositoryBase<CarType>
    {
        ICollection<CarType> GetDriversByCarType(int id);

    }
}
