namespace _018_student
{

    class Student
    {
        
        private string name;
        private int age;
        private string major;

       
        public Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }

       
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Major: " + major);
        }
    }



    internal class Program
    { 
        static void Main(string[] args)
        {          
                Student student = new Student("홍길동", 20, "의료IT공학");
                student.DisplayInfo();
        }
    }
}
