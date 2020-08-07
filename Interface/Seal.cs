using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Seal : IPrey, IAnimal
    {
        private int _fleeSpeed;

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int FleeSpeed
        {
            get { return _fleeSpeed; }
            set { _fleeSpeed = value; }
        }

        public void Flee()
        {
            Console.WriteLine("Seal fleeing");
        }
    }
}
