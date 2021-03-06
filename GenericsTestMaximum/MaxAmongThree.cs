using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    //We are using CompareTo method to compare two variables
    //It returns 1: if variable1 is greater than variable2
    //returns 0: if variable1 is equal to variable2 AND
    //returns -1: if variable1 is less than variable2
    internal class MaxAmongThree
    {
        //Find maximum among three integers
        public int MaxAmongThreeInt(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            return num1;
        }

        //Find maximum ammong three floats
        public float MaxAmongThreeFloat(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            return num1;
        }

        //Find maximum among three strings
        public string MaxAmongThreeString(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) > 0 && str1.CompareTo(str3) > 0)
            {
                return str1;
            }
            if (str2.CompareTo(str1) > 0 && str2.CompareTo(str3) > 0)
            {
                return str2;
            }
            if (str3.CompareTo(str1) > 0 && str3.CompareTo(str2) > 0)
            {
                return str3;
            }
            return str1;
        }
    }
}