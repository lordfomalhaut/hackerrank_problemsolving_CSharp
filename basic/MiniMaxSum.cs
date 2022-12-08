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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        long min = arr.GetRange(0, arr.Count - 1).Sum(item => (long)item);
        long max = arr.GetRange(1, arr.Count - 1).Sum(item => (long)item);
        
        Console.WriteLine(String.Format("{0} {1}", min, max));
    }

}
