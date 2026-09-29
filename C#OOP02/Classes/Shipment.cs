

using C_OOP02.Struct;

namespace C_OOP02.Classes
{
    /// <summary>
    /// Represents a shipment with tracking, delivery, destination, and cost information.
    /// </summary>
    internal class Shipment
    {
        #region Private Fields

        string? trackingCode;
        string? description;
        decimal weight;
        decimal deliveryFee;

        #endregion

        #region Properties

        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }

        public string Description
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;

            }
        }

        public decimal Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }

            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }

        #endregion

        #region Constructor
        public Shipment(string _trackingCode)
        {
            TrackingCode = _trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }

        public Shipment(string _trackingCode, string _description, decimal _weight, decimal _deliveryFee, DeliveryAddress _destination)
        {
            TrackingCode = _trackingCode;
            Description = _description;
            Weight = _weight;
            DeliveryFee = _deliveryFee;
            Destination = _destination;
        }

        #endregion

        #region Methods
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");

        }

        #endregion
    }
}
