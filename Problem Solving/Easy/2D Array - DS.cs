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
    // https://www.hackerrank.com/challenges/2d-array/problem

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        var results = new List<int>();
        
        for (var iH = 0; iH < arr.Count() - 2; iH++) {
            for (var iV = 0; iV < arr[0].Count() - 2; iV++) {
                results.Add(arr[iH][iV] + arr[iH][iV + 1] + arr[iH][iV + 2] + arr[iH + 1][iV + 1] + arr[iH + 2][iV] + arr[iH + 2][iV + 1] + arr[iH + 2][iV + 2]);
            }
        }
        
        return results.Max();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
