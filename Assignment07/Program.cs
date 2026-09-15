namespace Assignment07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            // a) A class is a reference type while a struct is a value type
            // When a struct is copied a separate copy is created
            // When a class object is copied both variables refer to the same object

            // b) Classes are more suitable for large applications because they are
            // suitable for complex objects and relationships between objects

            #endregion
            #region Question 2

            // a) Shipment is the parent class

            // b) ExpressShipment is the child class

            // c) ExpressShipment inherits the TrackingCode property from Shipment
            // ExtraFee is a new property in ExpressShipment

            // d) Inheritance allows us to reuse the same properties and methods
            // without duplicating the code in multiple classes

            #endregion
        }
    }
}
