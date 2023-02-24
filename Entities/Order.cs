using Proj2302.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2302.Entities
{
    public class Order
    {

        internal DateTime Moment { get; set; }
        internal OrderStatus Status { get; set; } 
        internal Client Client { get; set; }
        internal List<OrderItem>? Items { get; set;} = new List<OrderItem>();

        public Order
            (
            Client client,
            OrderStatus orderStatus
            )
        {
            Moment = DateTime.Now;
            Status = orderStatus;
            Client = client;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

        public void AddItem(OrderItem item)
        {

            Items.Add(item);

        }

        public void RemoveItem(OrderItem item)
        {

            Items.Remove(item);

        }

        public double Total()
        {
            double _total = 0.0;

            foreach (OrderItem item in Items)
            {
               _total = _total + item.SubTotal();
            }

            return _total;

        }



    }
}
