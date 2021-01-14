using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Domain;
using RepositoryPattern;
namespace Exam03Project
{
    class Program
    {
        public static object RepositoryFactory { get; private set; }

        static void Main(string[] args)
        {
            bool isRun = true;
            while (isRun)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("================= Select Your Process =================");
                Console.WriteLine("Press 1 : To Get a Student Information");
                Console.WriteLine("Press 2 : To Create a New Student Information");
                Console.WriteLine("Press 3 : To Exit The Application");
                string inputKey = Console.ReadLine();
                Console.Clear();
                if (inputKey == "1")
                {
                    var source =
                   RepositoryFactory.Create<IStudentRepository>(ContextTypes.XMLSource);
                    var items = source.GetAll();
                    Console.WriteLine();
                    Console.WriteLine("=============Student Information===========");
                    foreach (var item in items)
                    {
                        Console.WriteLine(item.StudentName + ", " + item.CourseName + ", " +
                       item.RoundNo + ", " + item.CellPhoneNo);
                    }
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (inputKey == "2")
                {
                    Student trn = new Student();
                    Console.Write("Student Name : ");
                    trn.StudentName = Console.ReadLine();
                    Console.Write("Course Name : ");
                    trn.CourseName = Console.ReadLine();
                    Console.Write("Round No. : ");
                    trn.RoundNo = Console.ReadLine();
                    Console.Write("Cell Phone No. : ");
                    trn.CellPhoneNo = Console.ReadLine();
                    Console.Clear();
                    IStudentRepository source =
                   RepositoryFactory.Create<IStudentRepository>(ContextTypes.XMLSource);
                    try
                    {
                        source.Insert(trn);
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        Console.ReadKey();
                        continue;
                    }
                }
                else if (inputKey == "3")
                {
                    isRun = false;
                }
            }
        }
    }
}
