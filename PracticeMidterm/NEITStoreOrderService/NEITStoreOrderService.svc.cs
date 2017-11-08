﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NEITStoreOrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class NEITStoreOrderService : INEITStoreOrderService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int ReturnDoubleOrderID(int OrderID)
        {
            int value;
            value = OrderID * 2;
            return value;
        }

        public OrderInfo GetOrder(string OrderID)
        {
            OrderInfo myOrder = new OrderInfo();
            Item[] myItem = new Item[2];

            myOrder.OrderID = "1";
            myOrder.ShopperAddress = "101 Main Street";
            return myOrder;
        }
    }
}
