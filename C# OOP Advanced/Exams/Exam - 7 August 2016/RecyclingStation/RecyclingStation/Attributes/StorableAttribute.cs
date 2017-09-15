namespace RecyclingStation.Attributes
{
    using System;
    using RecyclingStation.WasteDisposal.Attributes;

    public class StorableAttribute : DisposableAttribute
    {
        public StorableAttribute(Type connectingAttribute) : base(connectingAttribute)
        {
        }
    }
}
