using System.Runtime.Serialization;

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
