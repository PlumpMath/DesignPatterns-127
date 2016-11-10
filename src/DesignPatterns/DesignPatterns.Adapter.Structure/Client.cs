namespace DesignPatterns.Adapter.Structure
{
    public class Client
    {
        IAdapter adapter;

        public Client(IAdapter adapter)
        {
            this.adapter = adapter;
        }

        /// <summary>
        /// Suppose the Client can only supply string data
        /// Therefore he can't call the Adaptee.SpecificOperation() directly
        /// Because this one requires an Int as an input
        /// <para>Here comes the role of the adapter</para>
        /// </summary>
        /// <param name="strData"></param>
        public void Caller(string strData)
        {
            adapter.Operation(strData);
        }
    }
}
