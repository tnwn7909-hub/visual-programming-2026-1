namespace _016_class2
{
    
    class Date
    {
        //데이터(필드, 속성 = 변수)
        private int year, month, day;

        //동작(메소드 = 함수),(setter). getter 
        public void SetYear(int year) { this.year = year; }

        public int GetYear() { return this.year; }   
    }


    internal class Program  
    {
        static void Main(string[] args)
        {
            Date birthday = new Date();
            //birthday.year = 2006;
            birthday.SetYear(2006);

            // Console.WriteLine("나는  {0}년생입니다.", birthday.year);
            Console.WriteLine("나는  {0}년생입니다.", birthday.GetYear());
        }
    }
}
