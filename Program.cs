using System;
using System.Collections.Generic;
using System.IO;


namespace Result
{
    class Program
    {
        static void Main(string[] args)
        {
            //get txt path
            var performanceSheet = "c:\\Performance.txt";
          
           //read the lines from the path
            var scores = System.IO.File.ReadAllLines(performanceSheet);
            for(int i=0; i<scores.Length; i++)
            {
                // remove the hypen from the array split them to indexes
                string [] student = scores[i].Split("-");
                
                //Get the scores of those below and above fifty add bonus points and append to the file and as wll output them.
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
