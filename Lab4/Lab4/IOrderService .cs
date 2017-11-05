using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        int GetNumberOfOrders();

        [OperationContract]
        double GetTotalCostForAnOrder(double OrderID);

        [OperationContract]
        ItemList GetItemListForOrder(ItemList items);

        [OperationContract]
        string HowManyOrderedForAPartNo(String sPartNo);

        [OperationContract]
        BillingAddress GetBillingAddressForAnOrder(BillingAddress address);
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
    public class ItemList
    {
        [DataMember]
        public string PartNo;
        [DataMember]
        public string Description;
        [DataMember]
        public double UnitPrice;
        [DataMember]
        public int Quantity;
        [DataMember]
        public double TotalCost;
        [DataMember]
        public string CustomerInfo;
    }

    [DataContract]
    public class BillingAddress
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Address;
        [DataMember]
        public string City;
        [DataMember]
        public string State;
        [DataMember]
        public string ZipCode;
    }
}
