﻿



using NUnit.Framework.Interfaces;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)

        public float add(float x, float y)
        {
            return x + y;
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)

        public double add(double x, double y)
        {
            return x + y;
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)
        
        public float subtract(float x, float y)
        {
            return x - y;
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed
        
        public string subtract(string s, char c)
        {

            string result = s.Replace(c.ToString(), "");

            return result;
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)

        public int multiply(int x, int y)
        {
            return x * y;
        }

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"

        public string multiply(string s, int x)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < x; i++)
            {
                if (i < x-1)
                {
                    sb.Append(s + ",");
                } else
                {
                    sb.Append(s);
                }

            }

            return sb.ToString();

            

        }
      
        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]

        public int[] multiply(string[] stringArray, int x)
        {
            int[] result = new int[stringArray.Length];

            int i = 0;
            foreach(string s in stringArray)
            {
                result[i] = int.Parse(s) * x;
                i++;
            }

            return result;
        }
    }
}
