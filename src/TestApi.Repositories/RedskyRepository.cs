using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Repositories
{
    class RedskyRepository
    {
        #region Fields

        private readonly IClientFactory _clientFactory;

        //private readonly IMapper _mapper;

        #endregion

        #region Constructors

        public CustomerProfileRepository(IClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }
    }
}
