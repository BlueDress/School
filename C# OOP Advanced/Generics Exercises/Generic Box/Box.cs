namespace Generic_Box
{
    public class Box<T>
    {
        private T storedValue;

        public Box(T value)
        {
            this.storedValue = value;
        }

        public override string ToString()
        {
            return $"{this.storedValue.GetType().FullName}: {this.storedValue}";
        }
    }
}
