using System;

namespace King_s_Gambit
{
    public delegate void UnderAttackEventHandler(object sender, EventArgs args);

    public class King
    {
        private string name;

        public King(string name)
        {
            this.Name = name;
        }

        public string Name { get { return this.name; } private set { this.name = value; } }

        public event UnderAttackEventHandler UnderAttack;

        public void KingUnderAttack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");

            if (this.UnderAttack != null)
            {
                this.UnderAttack(this, new EventArgs());
            }
        }
    }
}
