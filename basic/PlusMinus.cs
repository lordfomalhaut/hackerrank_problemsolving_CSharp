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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        //Order: positive, negative, zero ratio counter
        List<float> ratios = new List<float>() {0, 0, 0};
        
        foreach(int num in arr)
        {
            if(num > 0)
                ratios[0]++;
            else if(num < 0)
                ratios[1]++;
            else
                ratios[2]++;
        }
        
        foreach(var num in ratios)
        {
            Console.WriteLine(num/arr.Count);
        }
        
    }

}