using System;
class DrawShape {
    public float length, breadth, radius, side, hieght, breadthfortriangle; 
    float PI = 3.14;
  static void Main() {
    DrawShape shape = new DrawShape();  
    shape.Circle();  
    shape.Rectangle();  
    shape.Triangle();  
    Console.ReadKey();  
  }
  
    public void Circle(){
      Console.WriteLine("Enter the Radius: ");
      radius = float.Parse(Console.ReadLine());
      Console.WriteLine("Area of circle is : {0}",  PI * radius * radius);
      Console.WriteLine("Area of Perimeter  is : {0}",  2 * PI * radius);
    }
  
    public void Triangle(){
        Console.WriteLine("Enter the Breadth for Triangle : ");  
        breadthfortriangle = float.Parse(Console.ReadLine());  
        Console.WriteLine("Enter the Hieght for Triangle : ");  
        hieght = float.Parse(Console.ReadLine()); 
        Console.WriteLine("Area of triangle :{0}", (breadthfortriangle * hieght) / 2); 
        Console.WriteLine("Perimeter of triangle : {0}",  hieght + hieght + breadthfortriangle);
    }
  
    public void Rectangle() {  
        Console.WriteLine("Enter the Length for Rectangle :");  
        length = float.Parse(Console.ReadLine());  
        Console.WriteLine("Enter the breadth for Rectangle :");  
        breadth = float.Parse(Console.ReadLine());  
        Console.WriteLine("Area of rectangle is :{0}", length * breadth);
        Console.WriteLine("Perimeter of rectangle is :{0}", (length + breadth) * 2);
    } 
}
