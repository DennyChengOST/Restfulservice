using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.ServiceModel.Types
{
    public class ProductPrice
    {
        [DataMember(Order = 1)]
        public decimal Value{ get; set; }

        [DataMember(Order = 2)]
        public string CurrencyCode{ get; set; }
    }
}
