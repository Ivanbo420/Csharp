using System;
namespace Datatypes
{
    class Program
    {
        readonly System.Char[] s = new System.Char[] {'a', 'b', 'c'};
        readonly System.Char[] s_new = new System.Char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
        public static void Main(string[] args)
        {
            Type stype = typeof(string);
            System.Diagnostics.Debug.WriteLine(stype.FullName);

            int i = 5;
            System.Diagnostics.Debug.WriteLine(i++);
            System.Diagnostics.Debug.WriteLine(i--);

            //when changing type from float to int, the value is truncated
            System.Diagnostics.Debug.WriteLine((int)1.5f);

            //absolute value
            System.Diagnostics.Debug.WriteLine(Math.Abs(-3));
            System.Diagnostics.Debug.WriteLine(Math.Abs(-8.12f));

            //rounding
            System.Diagnostics.Debug.WriteLine(Math.Round(4.7));
            System.Diagnostics.Debug.WriteLine(Math.Round(4.2));

            //ceiling
            System.Diagnostics.Debug.WriteLine(Math.Ceiling(4.7));
            System.Diagnostics.Debug.WriteLine(Math.Ceiling(4.2));

            //floor
            System.Diagnostics.Debug.WriteLine(Math.Floor(4.7));
            System.Diagnostics.Debug.WriteLine(Math.Floor(4.2));

            //truncation
            System.Diagnostics.Debug.WriteLine(Math.Truncate(2.7));
            System.Diagnostics.Debug.WriteLine(Math.Truncate(2.2));

            //min
            System.Diagnostics.Debug.WriteLine(Math.Min(100, 3));

            //max
            System.Diagnostics.Debug.WriteLine(Math.Max(100, 3));
            System.Console.WriteLine("Hello World!");

            //strings
            string firstName = "John";
            string emptyString = "";
            string emptyString2 = String.Empty;

            //string concatenation
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            fullName += " Jr.";
            System.Diagnostics.Debug.WriteLine(fullName);

            string s1 = "abc"; //the same as above declaration
            s1+= "def"; //same as creating a new object and assigning it to s1 like above

            //string equality
            string s2 = "abc";
            System.Diagnostics.Debug.WriteLine(s1 == s2);
            System.Diagnostics.Debug.WriteLine(s1.Equals(s2));
            System.Diagnostics.Debug.WriteLine(string.Equals(s1, s2)); 

            //string verbating @ - verbating
            string path = "c:\\projects\\project1\\folder1";
            string path2 = @"c:\projects\project1\folder1";
            System.Diagnostics.Debug.WriteLine(path);
            System.Diagnostics.Debug.WriteLine(path2);

            //string interpolation $ - string interpolation
            string s3 = $"The name is {fullName}";
            System.Diagnostics.Debug.WriteLine(s3);
            System.Diagnostics.Debug.WriteLine($"The name is {fullName}");

            //string substrings contains, substring and split
            string s4 = "The quick brown fox jumps over the lazy dog";
            System.Diagnostics.Debug.WriteLine(s4.Contains("dog"));
            System.Diagnostics.Debug.WriteLine(s4.Substring(16));
            System.Diagnostics.Debug.WriteLine(s4.Substring(16, 3));

            //string escape sequences
            string s5 = "The quick brown fox \n jumps over the lazy dog";
            System.Diagnostics.Debug.WriteLine(s5);
            string s6 = "The quick brown fox \t jumps over the lazy dog";
            System.Diagnostics.Debug.WriteLine(s6);
            string s7 = "The quick brown fox \\ jumps over the lazy dog";
            System.Diagnostics.Debug.WriteLine(s7);
            string s8 = "The quick brown fox \" jumps over the lazy dog";
            System.Diagnostics.Debug.WriteLine(s8);


            //formstting strings
            int price1 = 123;
            int price2 = 1234;
            int price3 = 12345;
            System.Diagnostics.Debug.WriteLine(string.Format("The item costs {0:C} ", price1));
            System.Diagnostics.Debug.WriteLine(string.Format("The price of item 1 costs {0:C} \nthe price of item 2 costs {1:C} \nthe price of item 3 costs {2:C} ", price1, price2, price3));

            float percent = 0.5f;
            System.Diagnostics.Debug.WriteLine(string.Format("The percent is {0:P}", percent));





        } 
    }
}