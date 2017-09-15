namespace RecyclingStation.Attributes
{
    using System;
    using RecyclingStation.WasteDisposal.Attributes;

    public class RecyclableAttribute : DisposableAttribute
    {
        public RecyclableAttribute(Type connectingAttribute) : base(connectingAttribute)
        {
        }
    }
}
