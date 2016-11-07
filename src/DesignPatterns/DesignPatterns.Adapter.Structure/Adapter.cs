namespace DesignPatterns.Adapter.Structure
{
    public class Adapter : IAdapter
    {
        Adaptee _adaptee;

        public void Operation(string strData)
        {
            // The adapter will plug the call to Adaptee.SpecificOperation
            // By carrying out the task of converting String data to and Int
            // And supplying it to the Adaptee

            int iData;
            int.TryParse(strData, out iData);

            _adaptee.SpecificOperation(iData);
        }
    }
}
