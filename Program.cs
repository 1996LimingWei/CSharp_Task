
using System;
using System.Text.RegularExpressions;

class test
{
    public static bool MatchString(string text, string pattern)
    {
        Regex re = new Regex(pattern);
        if (re.IsMatch(text))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //string pattern = "^[A-Za-z0-9/]*$"; string pattern = "[0-9]+"; 
    public static void Main(string[] args)
    {
        string test_string1 = "!@#asd232";
        string test_string2 = "ab@12";//abc123
        string test_string3 = "abc123xyzw98";
        string test_string4 = "<TagName1/><TagName2/>A quick brown fox jumps over lazy dog<TagName3/>";

        //Q1
        string pattern_1 = "[0-9a-zA-Z]*";
        if (MatchString(test_string1, pattern_1) == true)
        {
            Console.WriteLine("Pattern " + pattern_1 + " matches " + test_string1);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Pattern " + pattern_1 + " does not matches " + test_string1);
            Console.ReadLine();
        }
        //Q2
        string pattern_2 = "^[A-Za-z0-9/]*$";
        if (MatchString(test_string2, pattern_2) == true)
        {
            Console.WriteLine("Pattern " + pattern_2 + " matches " + test_string2);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Pattern " + pattern_2 + " does not matches " + test_string2);
            Console.ReadLine();
        }
        //Q3
        string pattern_3 = "[0-9]+";
        Regex regex = new Regex(pattern_3);
        MatchCollection output = regex.Matches(test_string3);
        foreach (Match match in output)
        {
            Console.WriteLine("Matched Number is : {0}", match.Value);
            Console.ReadLine();

        }
        //Q4
        string pattern_4 = @"\<.*?\>"; //@ escape specfical character
        Regex regex_4 = new Regex(pattern_4);
        MatchCollection result = regex_4.Matches(test_string4);
        foreach (Match match in result)
        {
            Console.WriteLine("Matched Number is : {0}", match.Value);
            Console.ReadLine();

        }
    }
}