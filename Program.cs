using System;
using System.Collections.Generic;
using System.IO;


namespace Result
{
    class Program
    {
        static void Main(string[] args)
        {
            var performanceSheet = "c:\\Performance.txt";
           // File.Create(performanceSheet);
            foreach (var line in File.ReadAllLines(performanceSheet))
            {
               Console.WriteLine(line);
            }
            var scores = System.IO.File.ReadAllLines(performanceSheet);
            for(int i=0; i<scores.Length; i++)
            {
                string [] student = scores[i].Split("-");

                if (Convert.ToInt32(student[1]) < 50)
                {
                    Console.WriteLine($" Below fifty student results: {student[0]} -{student[1]}");
                    var bonusMark = Convert.ToInt32(student[1]) + 10;
                    var afterMark = student[0] + bonusMark;
                    File.AppendAllLines(performanceSheet, new string[] {afterMark});
                    Console.WriteLine($"Result after adding bonus marks: {student[0]} - {bonusMark}");
                  
                }

                else if (Convert.ToInt32(student[1]) >= 50)
                {
                    Console.WriteLine($" Above fifty student results: {student[0]} - {student[1]}");
                    var bonusMarks = Convert.ToInt32(student[1]) + 5;
                    var afterMark = student[0] + bonusMarks;
                    File.AppendAllLines(performanceSheet, new string[] { afterMark });
                    Console.WriteLine($"Result after adding bonus marks: {student[0]} - {bonusMarks}");
                }
                else
                {
                    throw new ArgumentException("Out of range");
                }
                
            }

         
            

           

          
        }
    }
}
