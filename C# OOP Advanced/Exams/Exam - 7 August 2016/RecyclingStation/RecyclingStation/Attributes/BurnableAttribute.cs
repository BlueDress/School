namespace RecyclingStation.Attributes
{
    using System;
    using RecyclingStation.WasteDisposal.Attributes;

    public class BurnableAttribute : DisposableAttribute
    {
        public BurnableAttribute(Type connectingAttribute) : base(connectingAttribute)
        {
        }
    }
}
