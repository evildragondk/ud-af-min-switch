using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IPrey : IAnimal
    {
        int FleeSpeed { get; set; }

        void Flee ();
    }
}
