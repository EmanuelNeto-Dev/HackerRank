using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim()); // 4
            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim()); // 73 67 38 33
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));
            Console.ReadKey();
        }
    }

    class Result
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            var gradesRevised = new List<int>();
            
            if (grades.Count == 0)
                return grades;
            
            foreach (var grade in grades)
            {
                var mod = (grade + 2) % 5;
                
                if(mod >= 0 && mod <= 2 && grade > 37)
                    gradesRevised.Add(grade + (2 - mod));
                else
                    gradesRevised.Add(grade);
            }

            return gradesRevised;
        }
    }
}
