using System;

namespace Assignment07.Entities
{
    public class DeliveryCenter
    {
        private Shipment?[] shipments;

        public string CenterName { get; set; }

        public DeliveryCenter(string centerName)
        {
            CenterName = string.IsNullOrWhiteSpace(centerName) ? "Unknown" : centerName;

            shipments = new Shipment?[20];
        }

        public Shipment? this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }

                return default;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment? this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null &&
                        shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine("==================================================");

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine();
                }
            }
        }
    }
}