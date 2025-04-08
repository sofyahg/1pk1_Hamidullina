using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    internal class Order

    {
        public OrderStatus Status { get; set; }

        public Order()
        {
            Status = OrderStatus.New;
        }
        /// <summary>
        /// статус переходит к следующему по цепочке только в случае если
        /// заказ не отменен или не доставлен
        /// </summary>
        public void ChangeStatus()
        {
            if (Status != OrderStatus.Cancelled && Status != OrderStatus.Delivered)
            {
                Status++;
                Console.WriteLine($"статус заказа изменён на {Status}");
            }
            else
            {
                Console.WriteLine("Невозможно изменить статус заказа, так как он уже отменён или доставлен");
            }
        }

        public void CancelOrder()
        {
            if (Status != OrderStatus.Cancelled && Status != OrderStatus.Delivered)
            {
                Status = OrderStatus.Cancelled;
                Console.WriteLine("Заказ отменён");
            }
            else { Console.WriteLine("Невозможно изменить статус заказа, так как он уже отменен или доставлен"); }
        }
    }
}
