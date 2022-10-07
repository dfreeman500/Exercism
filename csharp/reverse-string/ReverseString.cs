using System;
using System.Linq;


//Option 1 uses Linq

public static class ReverseString
{
    public static string Reverse(string input)
    {
        return new string(input.Reverse().ToArray());
    }
}




//Option 2 turns the string into a char array, reverses the array, then convert to string


// public static class ReverseString
// {
//     public static string Reverse(string input)
//     {
//            char[] array = input.ToCharArray();
//            Array.Reverse(array);
//            return new String(array);
//     }
// }


