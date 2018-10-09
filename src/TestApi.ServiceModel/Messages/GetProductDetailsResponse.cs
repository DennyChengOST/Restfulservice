using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TestApi.ServiceModel.Types;

namespace TestApi.ServiceModel.Messages
{
    [DataContract]
    public class GetProductDetailsResponse :IHasResponseStatus
    {
        #region IHasResponseStatus Implementation

        [DataMember(Order = 1)]
        public ResponseStatus ResponseStatus { get; set; }

        #endregion

        [DataMember(Order = 2)]
        public Int64 Id { get; set; }

        [DataMember(Order = 3)]
        public string Name { get; set; }

        [DataMember(Order = 4)]
        public ProductPrice CurrentPrice { get; set; }
    }
}
