using System;

namespace King_s_Gambit
{
    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string name) : base(name)
        {
        }

        public override void OnUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!"); 
        }
    }
}
