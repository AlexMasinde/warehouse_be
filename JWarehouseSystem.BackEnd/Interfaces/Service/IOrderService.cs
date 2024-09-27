using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.BackEnd.Interfaces
{
    public interface IOrderService : IBaseService<IOrder>
    {
        ICollection<IOrderItem> GetOrderItems(int orderID);
       void AddItem(IOrderItem item, ICollection<IOrderItem> collection);
       void AddItems(ICollection items, ICollection<IOrderItem> collection);
       void RemoveItem(IOrderItem item, ICollection<IOrderItem> collection);
        void RemoveItems(ICollection items, ICollection<IOrderItem> collection);


    }
}
