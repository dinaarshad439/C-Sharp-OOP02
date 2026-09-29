

using C_OOP02.Struct;

namespace C_OOP02.Classes
{
    /// <summary>
    /// Represents an international shipment with a destination country and customs fee.
    /// </summary>
    internal class InternationalShipment:Shipment
    {
        decimal customsFee;
        string destinationCountry;


        #region Properties
        
        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0) customsFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }

        }

        #endregion

        #region Constructor

        public InternationalShipment(string _trackingCode, string _description,
            decimal _weight, decimal _deliveryFee, DeliveryAddress _destination,string _destinationCountry,decimal _customFee)
            : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {
           DestinationCountry = _destinationCountry;
            CustomsFee= _customFee;
        }

        #endregion 

        
    }
}
