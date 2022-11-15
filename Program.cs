using System;

namespace HW121122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // example 1 - contains func
            string str = "Hello World";
            Console.WriteLine(str.Contains("Hello")); // true
            Console.WriteLine(str.Contains("hello")); // false
            
            // example 2 - copyTo func
            string str2 = "Hello World";
            char[] arr = new char[5];
            str2.CopyTo(6, arr, 0, 5);
            Console.WriteLine(arr); // World

            // example 3 - insert func
            string str3 = "Hello World";
            Console.WriteLine(str3.Insert(5, "C#")); // HelloC# World

            // example 4 - padRight func
            string str4 = "Hello World";
            Console.WriteLine(str4.PadRight(20, '*')); // Hello World*********
            
            // example 5 - replace func
            string str5 = "Hello World";
            Console.WriteLine(str5.Replace("Hello", "Hi")); // Hi World
            
            // example 6 - substring func
            string str6 = "Hello World";
            Console.WriteLine(str6.Substring(6)); // World
            Console.WriteLine(str6.Substring(6, 5)); // World

            // example 7 - ToCharArray func
            string str7 = "Hello World";
            char[] arr2 = str7.ToCharArray();
            Console.WriteLine(arr2); // Hello World

            // example 8 - Split func
            string str8 = "Hello World";
            string[] arr3 = str8.Split(' ');
            Console.WriteLine(arr3[0]); // Hello
            Console.WriteLine(arr3[1]); // World

            // example 9 - Trim func
            string str9 = " Hello World ";
            Console.WriteLine(str9.Trim()); // Hello World

            // example 10 - TrimStart func
            string str10 = " Hello World ";
            Console.WriteLine(str10.TrimStart()); // Hello World

            // example 11 - StartWith func
            string str11 = "Hello World";
            Console.WriteLine(str11.StartsWith("Hello")); // true
            Console.WriteLine(str11.StartsWith("hello")); // false

            // example 12 - indexOf func
            string str12 = "Hello World";
            Console.WriteLine(str12.IndexOf("World")); // 6
            Console.WriteLine(str12.IndexOf("W")); // 6
            Console.WriteLine(str12.IndexOf("world")); // -1
            
            //Ex. 1
            void change(string strg, string sub)
            {
                while (strg.Contains(sub)) {
                    strg.Replace(sub, "*");
                }
            }





        }
    }
}
