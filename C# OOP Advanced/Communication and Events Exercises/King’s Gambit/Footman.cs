using System;

namespace King_s_Gambit
{
    public class Footman : Soldier
    {
        public Footman(string name) : base(name)
        {
        }

        public override void OnUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!"); 
        }
    }
}
