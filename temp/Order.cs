using System;

namespace Testability
{
    public class Order
    {
        public bool IsShipped { get; set; }
        public float TotalPrice { get; set; }
        public Shipment Shipment { get; set; }
        public DateTime DatePlaced { get; set; }
    }
}
