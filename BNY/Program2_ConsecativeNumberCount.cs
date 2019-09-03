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
     * Complete the 'consecutive' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts LONG_INTEGER num as parameter.
     */

    public static int consecutive(long num)
    {
        int count = 0;
        if (num >= 0 && num <= 1000000000000)
        {

            for (long i = 1; i < num; i++)
            {

                long sum = 0;
                for (long j = i; j < num; j++)
                {

                    sum = i + j;
                    if (sum == num)
                    {
                        count++;
                        j = num;
                    }

                }
            }

        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long num = Convert.ToInt64(Console.ReadLine().Trim());

        int result = Result.consecutive(num);

        Console.WriteLine(result);
        Console.ReadLine();


        //textWriter.Flush();
        //textWriter.Close();
    }
}
