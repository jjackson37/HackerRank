using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    // https://www.hackerrank.com/challenges/grading/problem

    /*
     * Complete the gradingStudents function below.
     */
    static int gradingStudents(int grade) {
        var diff = grade % 5;
        if (grade >= 38 && diff > 2) {
            grade += 5 - diff;
        }
        
        return grade;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var n = Convert.ToInt32(Console.ReadLine());
        var grades = new List<int>();

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades.Add(gradesItem);
        }

        var gradesNew = grades.Select(grd => gradingStudents(grd));

        tw.WriteLine(string.Join("\n", gradesNew));

        tw.Flush();
        tw.Close();
    }
}
