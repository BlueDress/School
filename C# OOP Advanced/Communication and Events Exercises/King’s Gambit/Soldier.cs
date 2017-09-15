using System;

namespace King_s_Gambit
{
    public abstract class Soldier
    {
        private string name;

        public Soldier(string name)
        {
            this.Name = name;
        }

        public string Name { get {return this.name; } private set { this.name = value; } }

        public abstract void OnUnderAttack(object sender, EventArgs args);
    }
}
