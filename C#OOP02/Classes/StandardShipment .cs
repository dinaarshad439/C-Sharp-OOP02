using C_OOP02.Struct;


namespace C_OOP02.Classes
{
    /// <summary>
    /// 
    /// </summary>
    internal class StandardShipment:Shipment
    {
        #region Constructor

        public StandardShipment(string _trackingCode, string _description, decimal _weight, decimal _deliveryFee, DeliveryAddress _destination)
            :base(_trackingCode,_description,_weight,_deliveryFee,_destination) { }

        #endregion
    }
}
