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
    // https://www.hackerrank.com/challenges/repeated-string/problem

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        long numOfA = s.Count(x => x == 'a') * (long)Math.Floor((decimal)(n / s.Length));
        numOfA += s.Substring(0, (int)(n % s.Length)).Count(x => x == 'a');
        return numOfA;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
