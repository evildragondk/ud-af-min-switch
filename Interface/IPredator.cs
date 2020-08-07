using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IPredator : IAnimal
    {
        int AttackSpeed { get; set; }

        void Attack(IPrey prey);

    }
}
