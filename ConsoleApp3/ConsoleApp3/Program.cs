using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { FullName = "Rashad Abbasov", GroupNo = "P232" });
            students.Add(new Student { FullName = "Talib Arslanov", GroupNo = "P234" });
            students.Add(new Student { FullName = "Amrah Efendiyev", GroupNo = "D987" });
            students.Add(new Student { FullName = "Leyla Abdullayeva", GroupNo = "S345" });

            foreach (var item in students)
            {
                Console.WriteLine($"{item.No}  {item.FullName}    {item.GroupNo}");
            }

            Console.WriteLine("Silmek istediyiniz Student nomresini daxil edin");
            string noStr = Console.ReadLine();
            int no = int.Parse(noStr);

            Student student = FindStudentByNo(no, students);
            if (student==null)
            {
                Console.WriteLine("Bu nomrede Student mevcud deyil");
            }
            else
            {
                students.Remove(student);

                foreach (var item in students)
                {
                    Console.WriteLine($"{item.No}  {item.FullName}    {item.GroupNo}");
                }

            }


              Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");


            Dictionary<string, int> groups = new Dictionary<string, int>();
            groups.Add("P232", 45);
            groups.Add("P332", 66);
            groups.Add("P432", 56);
            groups.Add("P532", 78);

            foreach (var item in groups)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("GroupNo: ");
            string groupno = Console.ReadLine();


            if (groups.ContainsKey(groupno))          
                Console.WriteLine(groups[groupno]);

            else
                Console.WriteLine("Bu deyerde bir qrup yoxdur");








        }

        static Student FindStudentByNo(int no,List<Student> students)
        {
            foreach (var item in students)
            {
                if (item.No==no)
                {
                    return item;
                }
            }
            return null;
        }

    }
}