using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.setLength(10);
            box1.setBreadth(20);
            box1.setHeight(6);

            Box box2 = new Box();
            box2.setLength(5);
            box2.setBreadth(30);
            box2.setHeight(10);

            Box box3 = new Box();
            box3.setLength(2);
            box3.setBreadth(24);
            box3.setHeight(19);

            Console.WriteLine($"Volume of Box 1: {box1.getVolume()}");
            Console.WriteLine($"Volume of Box 2: {box2.getVolume()}");
            Console.WriteLine($"Volume of Box 3: {box3.getVolume()}");
        }
    }
}
