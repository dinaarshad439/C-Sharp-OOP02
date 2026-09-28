

namespace C_OOP02.Classes
{
    internal class DeliveryCenter
    {
        #region fields
        Shipment[] shipments;
        #endregion 

        #region Constructor
        public DeliveryCenter()
        {
            shipments = new Shipment[10];
        }
        #endregion 

        #region Indexers

        public Shipment this[int index]
        {
            get
            {
                
                  return index >= 0 && index < shipments.Length ? shipments[index] : default;


               
               

            }

            set
            {
                if (index >= 0 && index < shipments.Length) shipments[index] = value;
            }
        }

        public Shipment this[string index]
        {

            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] !=null && shipments[i].TrackingCode == index) return shipments[i];
                }
                return default;
            }
        }
        #endregion

        #region Methods

        /// <summary> 
        /// Adds a shipment to the first available position in the delivery center. 
        /// </summary> 
        /// <param name="shipment">The shipment to be added.</param> 
        /// <returns>
        /// true if the shipment was added successfully;
        /// otherwise, false if there is no available position.
        /// </returns>
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    Console.WriteLine("Shipment added successfully");
                    return true;

                }
            }

            return false;
        }
        #endregion
    }
}
