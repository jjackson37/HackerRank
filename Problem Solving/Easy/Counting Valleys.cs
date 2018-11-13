using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {
    // https://www.hackerrank.com/challenges/counting-valleys/problem

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        int valleyCount = 0, currentHeight = 0;
        
        foreach (var step in s){
            if (step == 'D'){
                if (currentHeight == 0) {
                    valleyCount++;
                }
                
                currentHeight--;
            } else {
                currentHeight++;
            }
        }
        
        return valleyCount;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
