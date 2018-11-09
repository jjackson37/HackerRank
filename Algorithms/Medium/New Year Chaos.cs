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
    // https://www.hackerrank.com/challenges/new-year-chaos/problem

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q) {
        var minBribes = 0;
        var reversedArray = q.Reverse();
        
        for (var i = 0; i < q.Length; i++){
            if (q[i] - (i + 1) > 2){
                Console.WriteLine("Too chaotic");
                return;
            }
            
            minBribes += reversedArray.Take(q.Length - i - 1).Count(x => x < q[i]);
        }
        
        Console.WriteLine(minBribes);
    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
            minimumBribes(q);
        }
    }
}
