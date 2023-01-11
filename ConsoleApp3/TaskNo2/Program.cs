using System;
using System.Security.Cryptography.X509Certificates;

namespace TaskNo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.FullName = "Javanshir";

            student1.AddExam("Math", 100);
            student1.AddExam("Fizika", 90);
            student1.AddExam("Ximiya", 45);
            student1.AddExam("Ana dili", 100);
            student1.AddExam("Inglis Dili", 95);

            foreach (var item in student1.ExamSubjects)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("Enter Subject");
            string subject = Console.ReadLine();

            var subjectPoint = student1.GetExamresult(subject);

            if (subjectPoint==null)
                Console.WriteLine("Bu deyerde bir fenn yoxdur");

            else
                Console.WriteLine(student1.GetExamresult(subject));


            Console.Write("Ortalama qiymete bax:  ");
            Console.WriteLine(student1.GetAvarage());



        }
    }
}
