using System;

namespace Shape
{
  class Program
  {
    static void Main(string[] args)
    {
      // Shape Test
      Shape shape = new Shape();
      Console.WriteLine(shape);

      shape = new Shape("red", false);
      Console.WriteLine(shape);

      // Circle Test
      Circle circle = new Circle();
      Console.WriteLine(circle);

      circle = new Circle(3.5);
      Console.WriteLine(circle);

      circle = new Circle(3.5, "indigo", false);
      Console.WriteLine(circle);

      // Square Test
      Square square = new Square();
      Console.WriteLine(square);

      square = new Square(2.3);
      Console.WriteLine(square);

      square = new Square(5.8, "yellow", true);
      Console.WriteLine(square);
            
            Resizeable[] resizeables = new Resizeable[3];
            resizeables[0] = new Circle();
            resizeables[1] = new Rectangle();
            resizeables[2] = new Square();
            Console.WriteLine("Truoc khi resize");
            for (int i = 0; i < resizeables.Length; i++)
            {
                Console.WriteLine(resizeables[i].ReSize(10));
            }
            Console.WriteLine("Sau khi resize");
            for (int i = 0; i < resizeables.Length; i++)
            {
                resizeables[i].Resize(10);
            }
        }
  }
}
