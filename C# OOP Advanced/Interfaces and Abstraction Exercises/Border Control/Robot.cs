namespace Border_Control
{
    internal class Robot : IEntrant
    {
        public string ID
        {
            get;
        }

        public string Name
        {
            get;
        }

        internal Robot(string model, string id)
        {
            this.Name = model;
            this.ID = id;
        }
    }
}
