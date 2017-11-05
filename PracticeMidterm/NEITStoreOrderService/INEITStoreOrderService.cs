using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NEITStoreOrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface INEITStoreOrderService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        string ReturnDoubleOrderID(int OrderID);

        [OperationContract]
        OrderInfo GetOrder(int OrderID);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class OrderInfo
    {
        [DataMember]
        public string Options;
        [DataMember]
        public double Cost;
        [DataMember]
        public string Name;
        [DataMember]
        public string Sku;
        [DataMember]
        public int OrderID;
        [DataMember]
        public string ShopperAddress;
        [DataMember]
        public string ShopperName;
    }
}
