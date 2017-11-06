using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab4
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        string GetNumberOfOrders(int OrderID);

        [OperationContract]
        string GetTotalCostForAnOrder(int OrderID);

        [OperationContract]
        Item[] GetItemListForOrder(int OrderID);

        [OperationContract]
        string HowManyOrderedForAPartNum(String sPartsNo);

        [OperationContract]
        BillingInformation[] GetBillingAddressForAnOrder(int OrderID);
    }

    [DataContract]
    public struct Order
    {
        [DataMember]
        public BillingInformation billinginfo;
        [DataMember]
        public ShippingInformation shippinginfo;
        [DataMember]
        public Item items;
    }

    [DataContract]
    public struct BillingInformation
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

    [DataContract]
    public struct ShippingInformation
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

    [DataContract]
    public struct Item
    {
        [DataMember]
        public string PartNo;
        [DataMember]
        public string Description;
        [DataMember]
        public string UnitPrice;
        [DataMember]
        public string Quantity;
        [DataMember]
        public string TotalCost;
        [DataMember]
        public CustomerOptions customeroptions;
    }

    [DataContract]
    public struct CustomerOptions
    {
        [DataMember]
        public string Size;
        [DataMember]
        public string Color;
    }
}
