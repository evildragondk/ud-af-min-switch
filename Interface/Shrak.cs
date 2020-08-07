using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Shrak : IPredator, IAnimal
    {
        private int _attackSpeed;

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int AttackSpeed
        {
            get { return _attackSpeed; }
            set { _attackSpeed = value; }
        }

        public void Attack(IPrey prey)
        {
            if (_attackSpeed > prey.FleeSpeed)
                Console.WriteLine("Caught prey");
            else
                Console.WriteLine("Prey escaped");
        }

        public void hunting()
        {
            Console.WriteLine("Shrak is hunting");
        }
    }
}
