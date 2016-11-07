namespace DesignPatterns.Adapter.Structure
{
    public class Client
    {
        IAdapter _adapter;

        public void Caller(string strData)
        {
            // Suppose the Client can only supply string data
            // He can't call the Adaptee.SpecificOperation() directly
            // Because this one requires an Int as an input

            // Here comes the role of the adapter

            _adapter.Operation(strData);
        }
    }
}
