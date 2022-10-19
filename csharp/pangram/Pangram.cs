using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {

        HashSet<char> arraySet = new HashSet<char>(input.ToLower());               //Creates a hashset from the string input
        
        HashSet<char>  alphabet = new HashSet<char>("abcdefghijklmnopqrstuvwxyz"); //Creates a hashset of the alphabet

        return alphabet.IsSubsetOf(arraySet);  


        
    }
}
