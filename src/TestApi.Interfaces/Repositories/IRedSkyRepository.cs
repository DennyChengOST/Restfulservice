using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Interfaces.Repositories
{
    public interface IRedSkyRepository
    {
        string GetProductName(Int64 id);
    }
}
