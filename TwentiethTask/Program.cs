using System;


namespace TwentiethTask
{
   public class Student 
    {
     public string name;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Сначала:");
            student.name = "Madeleine";
            OutputName(student);
            Console.WriteLine("После Изменения");
            SetName(student, "Willa");
            OutputName(student);
            Console.WriteLine("Нажмите <enter> Для Завершения Программы . . . ");
            Console.Read();
        }
        public static void OutputName(Student student)
        {
            Console.WriteLine("Student.name = {0}", student.name);
        }
        public static void SetName(Student student, string name)
        {
            student.name = name;
        }
    }
}
