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

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b) {
        var characterDictionary = new Dictionary<string, int>();

        foreach (var character in a){
            if (characterDictionary.ContainsKey(character.ToString())){
                characterDictionary[character.ToString()]++;
            }
            else{
                characterDictionary.Add(character.ToString(), 1);
            }
        }

        foreach (var character in b){
            if (characterDictionary.ContainsKey(character.ToString())){
                characterDictionary[character.ToString()]--;
            }
            else{
                characterDictionary.Add(character.ToString(), -1);
            }
        }

        return characterDictionary.Sum(x => Math.Abs(x.Value));
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
