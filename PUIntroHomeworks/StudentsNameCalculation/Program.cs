using System;
using System.Text;

namespace StudentsNameCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] student = System.IO.File.ReadAllLines(@"D:\Kolca\STD\PUIntroHomeworks\PUIntroHomeworks\StudentsNameCalculation\students.txt");
            int studentSum = 0;
            int smiley = '\u263a';
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in student)
            {
                student = line.Split(' ');
                string firstName = student[1];
                string fathersName = student[2];
                string lastName = student[3];
                string fullName = $"{firstName} {fathersName} {lastName}";

                for (int i = 0; i < fullName.Length; i++)
                {
                    studentSum = studentSum + (int)fullName[i];
                }
                if (studentSum > 15000)
                    Console.WriteLine($" {fullName} {(char)smiley} => {studentSum}");
            }
        }
    }
}
