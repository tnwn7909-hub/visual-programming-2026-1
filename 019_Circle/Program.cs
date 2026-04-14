namespace _019_Circle
{
    internal class Circle
    {
        private double radius;
        private string color;

        
        public Circle(double radius, string color)  {this.radius = radius; this.color = color;}

        
        public double GetArea()  {return 3.14 * radius * radius;}

        
        public void PrintInfo() {Console.WriteLine("반지름: " + radius);  Console.WriteLine("색깔: " + color); }
     
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10, "빨간색");


            Console.WriteLine("원의 면적: " + c.GetArea());
        }
    }


}
