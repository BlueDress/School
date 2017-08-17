

namespace System_Split.Entities.Component
{
    public abstract class Component
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Component(string name)
        {
            this.Name = name;
        }
    }
}
