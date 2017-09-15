namespace RecyclingStation.WasteDisposal.Attributes
{
    using System;

    /// <summary>
    /// An attribute class, that represents the base of all Disposable Attribute classes.
    /// </summary>
    
    [AttributeUsage(AttributeTargets.Class)]
    public class DisposableAttribute : Attribute
    {
        private Type connectingAttribute;

        public DisposableAttribute(Type connectingAttribute)
        {
            this.ConnectingAttribute = connectingAttribute;
        }

        public Type ConnectingAttribute
        {
            get
            {
                return this.connectingAttribute;
            }

            private set
            {
                this.connectingAttribute = value;
            }
        }
    }
}
