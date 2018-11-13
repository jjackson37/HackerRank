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
    // https://www.hackerrank.com/challenges/ctci-bubble-sort

    // Complete the countSwaps function below.
    static void countSwaps(int[] a) {
        int lastUnsorted = a.Length - 1, swaps = 0;
        var sorted = false;

        while (!sorted) {
            sorted = true;

            for (int j = 0; j < lastUnsorted; j++) {
                if (a[j] > a[j + 1]) {
                    swap(a, j, j + 1);
                    swaps++;
                    sorted = false;
                }
            }
            
            lastUnsorted--;
        }

        Console.Write($"Array is sorted in {swaps} swaps.\nFirst Element: {a.First()}\nLast Element: {a.Last()}");
    }

    static void swap(int[] a, int x, int y) {
        var temp = a[x];
        a[x] = a[y];
        a[y] = temp;
    }
    
    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        countSwaps(a);
    }
}
