namespace Event_Implementation
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs e);

    public class Dispatcher
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                OnNameChange(new NameChangeEventArgs(this.name));
            }
        }

        public event NameChangeEventHandler NameChange;

        private void OnNameChange(NameChangeEventArgs args)
        {
            NameChange(this, args);
        }
    }
}
