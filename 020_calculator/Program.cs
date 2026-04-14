namespace _020_calculator
{
    
    class Calculator
    {
        public static double Add(double x, double y) { return x + y; }
        public static double Subtract(double x, double y) {return x - y; }
        public static double Multiply(double x, double y) {  return x * y; }
        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine(("0으로 나눌 수 없습니다."); 
                return 0;
            }

            else
                return x / y;
        


        }

    } 
    
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3.5;
            double b = 6.7;

            double sum = Calculator.Add(a, b);
            double diff = Calculator.Subtract(a, b);
            double prod = Calculator.Multiply(a, b);
            double quot = Calculator.Divide(a, b);

            Console.WriteLine("덧셈 :" + sum);
            Console.WriteLine("뺄셈 :" + diff);
            Console.WriteLine("곱셈 :" + prod);
            Console.WriteLine("나눗셈 : {0:F4}",quot);

        }
    }
}
