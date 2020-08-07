using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shrak tabby = new Shrak();
            tabby.AttackSpeed = 30;

            Seal bubbles = new Seal();
            bubbles.FleeSpeed = 22;

            tabby.hunting();
            tabby.Attack(bubbles);
        }
    }
}
