using System;

namespace Abstract_Class
{
    class Program
    {

        static void Main()
        {
            Cube cube = new Cube();
            cube.Height = 2.5;
            OutputDimensions("Cube", cube);

            Sphere sphere = new Sphere();
            sphere.Height = 2.5;
            OutputDimensions("Sphere", sphere);
        }

        static void OutputDimensions(string name, ThreeDObject object3D)
        {
            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine("Height\t{0:f2}m", object3D.Height);
            Console.WriteLine("Area\t{0:f2}m2", object3D.SurfaceArea);
            Console.WriteLine("Volume\t{0:f2}m3", object3D.CalculateVolume());
            Console.WriteLine("V:A\t{0:f2}", object3D.CalculateVolumeToAreaRatio());
        }

        /* OUTPUT
 
          Cube
          Height  2.50m
          Area    37.50m2
          Volume  15.63m3
          V:A     0.42
 
          Sphere
          Height  2.50m
          Area    19.63m2
          Volume  6.14m3
          V:A     0.31
 
        */
    }
}
