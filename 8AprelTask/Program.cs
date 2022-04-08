using System;
using System.Collections.Generic;

namespace _8AprelTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            

            bool activeMenu = true;
            do
            {
                Menu();
                string choice = Console.ReadLine();
                if(choice == "0")
                    activeMenu = false;
                else
                {
                    int no;
                    string examName;
                    Student newStudent;
                    switch (choice)
                    {

                        case "1":
                            Console.WriteLine("Fullname :");
                            string fullName = Console.ReadLine();
                            Student student = new Student()
                            {
                                FullName = fullName,
                            };
                            students.Add(student);
                            break;
                        case "2":
                            Console.WriteLine("No :");
                            no = int.Parse(Console.ReadLine());
                            Console.WriteLine("Exam name :");
                            examName = Console.ReadLine();
                            Console.WriteLine("Point :");
                            int point = int.Parse(Console.ReadLine());
                            newStudent = students.Find(x => x.No == no);
                            newStudent.AddExam(examName, point);
                            break;
                        case "3":
                            Console.WriteLine("No :");
                            no = int.Parse(Console.ReadLine());
                            Console.WriteLine("Exam name :");
                            examName = Console.ReadLine();
                            newStudent = students.Find(x => x.No == no);
                            Console.WriteLine(newStudent._exams[examName]);
                            break;
                        case "4":
                            Console.WriteLine("No :");
                            no = int.Parse(Console.ReadLine());
                            Student newStudent2 = students.Find(x => x.No == no);
                            foreach (var item in newStudent2._exams)
                            {
                                Console.WriteLine(item.Key);
                                Console.WriteLine(item.Value);
                                Console.WriteLine("------");
                            }
                            break;
                        case "5":
                            Console.WriteLine("No :");
                            no = int.Parse(Console.ReadLine());
                            Student newStudent3 = students.Find(x => x.No == no);
                            Console.WriteLine(newStudent3.GetExamAvg());
                            break;
                        case "6":
                            Console.WriteLine("No :");
                            no = int.Parse(Console.ReadLine());
                            Console.WriteLine("Exam name :");
                            examName = Console.ReadLine();
                            Student newStudent4 = students.Find(x => x.No == no);
                            newStudent4._exams.Remove(examName);
                            break;

                        default:
                            Console.WriteLine("Bu secim yoxdur !");
                            break;
                    }
                }
                
            } while (activeMenu);
            

        }
        static void Menu()
        {
            Console.WriteLine("Menu :");
            Console.WriteLine("1. Tələbə əlavə et");
            Console.WriteLine("2. Tələbəyə imtahan əlavə et");
            Console.WriteLine("3. Tələbənin bir imtahan balına bax");
            Console.WriteLine("4. Tələbənin bütün imtahanlarını göstər");
            Console.WriteLine("5. Tələbənin imtahan ortalamasını göstər");
            Console.WriteLine("6. Tələbədən imtahan sil");
            Console.WriteLine("0. Proqramı bitir");
        }
    }
}

