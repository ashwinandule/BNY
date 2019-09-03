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



class Result
{

    /*
     * Complete the 'countPalindromes' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int countPalindromes(string s)
    {
        if (!string.IsNullOrEmpty(s))
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j < s.Length + 1 - i; j++)
                {
                    if (isPalindromes(s.Substring(i, j)))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        else
        {
            return 0;
        }
    }

    public static bool isPalindromes(string s)
    {
        string reversStr = stringReverse(s);
        if (s == reversStr)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static string stringReverse(string s)
    {
        return new string(s.ToCharArray().Reverse().ToArray());
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.countPalindromes(s);

        Console.WriteLine(result);
        Console.ReadLine();

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
