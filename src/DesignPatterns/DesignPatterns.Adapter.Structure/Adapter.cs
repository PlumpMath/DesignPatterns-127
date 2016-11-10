namespace DesignPatterns.Adapter.Structure
{
    public class Adapter : IAdapter
    {
        Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        /// <summary>
        /// The adapter will plug-in the call to Adaptee.SpecificOperation
        /// By carrying out the task of converting String data to and Int
        /// And supplying it to the Adaptee
        /// </summary>
        /// <param name="strData"></param>
        public void Operation(string strData)
        {
            int iData;
            int.TryParse(strData, out iData);

            adaptee.SpecificOperation(iData);
        }
    }
}
