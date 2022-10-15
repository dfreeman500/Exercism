using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.Replace(" ","");                          // removes spaces
        word = word.Replace("-","");                          // removes -
        word = word.ToLower();                                // converts all to lowercase
        char[] chArray = word.ToCharArray();                  // converts string to char array
        HashSet<char> arraySet = new HashSet<char>(chArray);  // converts to set


        //if the length/count of the set and the string are the same then it is an isogram
        // if they are different than some letter is duplicated.

        
        return arraySet.Count == word.Length;
    }
}


//A very elegant solution using Linq is here : 
// https://exercism.org/tracks/csharp/exercises/isogram/solutions/ErikSchierboom