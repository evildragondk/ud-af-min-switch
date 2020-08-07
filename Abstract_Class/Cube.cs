using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    class Cube : ThreeDObject
    {
        public override int ReadWriteProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int ReadOnlyProperty => throw new NotImplementedException();

        public override int WriteOnlyProperty { set => throw new NotImplementedException(); }

        public override double SurfaceArea
        {
            get { return Math.Pow(Height, 2) * 6; }
        }

        public override double CalculateVolume()
        {
            return Math.Pow(Height, 3);
        }
    }
}
