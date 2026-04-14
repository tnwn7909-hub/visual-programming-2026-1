namespace _021_RectangleP
{

    class Rectangle
    {
        public int width { get; set; } // 속성(대문자) public
        public int height { get; set; }
        public int GetArea()
        {
            return width * height;
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.width = 10;
            r.height = 10;
            Console.WriteLine();


        }
    }
}
