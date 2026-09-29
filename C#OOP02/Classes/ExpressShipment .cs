

using C_OOP02.Struct;

namespace C_OOP02.Classes
{
    /// <summary>
    /// 
    /// </summary>
    internal class ExpressShipment:Shipment
    {
        decimal extraFee;
        
        #region Property

        public decimal ExtraFee {
            get { return extraFee; } 
            set { if (value >= 0) extraFee = value; }
        }

        #endregion

         public override decimal EstimatedCost
         {
            get { return DeliveryFee + (Weight * 5) + ExtraFee ;}
            
         }

        public ExpressShipment (string _trackingCode, string _description, decimal _weight, 
            decimal _deliveryFee, DeliveryAddress _destination,decimal _extraFee)
            : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {
            ExtraFee = _extraFee;
        }

    }
}
