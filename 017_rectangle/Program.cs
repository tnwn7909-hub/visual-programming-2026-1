
 //////////////// 시험문제
 ///
namespace _017_rectangle
{
    internal class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double w, double h)  //생성자
        {
            this.width = w;

            this.height = h;
        }

        public double GetArea()
        {
            return width * height;
        }

        public double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 3);
            
            
            double area = rect.GetArea();
            double perimeter = rect.GetPerimeter();

            Console.WriteLine("넓이: {0}\n 둘레 : {1}\n", area, perimeter);
            Console.WriteLine($"넓이: {area}\n둘레 : {perimeter}\n ");

        }
    }
}


///////////  시험문제  
/// 반지름(double radius) 색깔(string color)


/// 생성자 메소드
///   Circle c = new Circle(3.5, "빨간색");
/// 

/// 메소드
///   GetArea() //원의 면적을 계산
///   Printinfo() // 원의 반지름과 색깔 출력
