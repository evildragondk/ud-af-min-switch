using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    class Sphere : ThreeDObject
    {
        public override int ReadWriteProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int ReadOnlyProperty => throw new NotImplementedException();

        public override int WriteOnlyProperty { set => throw new NotImplementedException(); }

        public override double SurfaceArea
        {
            get { return 4 * Math.PI * Math.Pow(Height / 2, 2); }
        }
            

        public override double CalculateVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(Height / 2, 3);
        }
    }
}
