using System;
namespace day3
{
    class student(int id,string name,int age)
    {
        /*
        int id;
        string name;
        int age;

        public student(int Id,string Name,int Age)
        {
            id = Id;
            name = Name;
            age = Age;

        }
        */
        static student()
        {
            Console.WriteLine("hello");
        }

        /*
        public void getDate(int Id, string Name, int Age)
        {
            id = Id;
            name = Name;
            age = Age;
        }
        */

        public void setDate()
        {
            Console.WriteLine($" {id} - {name} - {age}");
        }
        public string isGradute()
        {
            if (age < 24)
                return $"{name} is gradute";
            else
                return $"{name} is not gradute";
        }
        class program
        {
            static void Main(string[] args)
            {
                student stu1 = new student(1,"omar",21);
                student stu2 = new student(2, "ali", 20);
                // stu1.getDate(1, "omar", 20);
                stu1.setDate();
                stu2.setDate();
                Console.WriteLine(stu1.isGradute());
                ////
                ////
                ///
 
            }
        }
    }
    
}