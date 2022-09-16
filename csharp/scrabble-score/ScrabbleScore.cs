using System;
using System.Collections.Generic;
using System.Linq;


public static class ScrabbleScore
{
    public static int Score(string input)
    {
        List<int> listOfValues = new List<int>(new int[input.Length]);
        for (int i=0; i<input.Length; i++){
            listOfValues[i] = Value(Char.ToLower(input[i]));
        }
        Console.WriteLine(listOfValues);
        return listOfValues.Sum();
    }

    public static int Value(char input){

        switch (input)
        {
            case 'q': case 'z':
                Console.WriteLine(10);
                return 10;
            case 'j': case 'x':
                Console.WriteLine(8);
                return 8;
            case 'k':
                return 5;
            case 'f': case 'h': case 'v': case 'w': case 'y':
                return 4;
            case 'b': case 'c': case 'm': case 'p':
                return 3;
            case 'd': case 'g':
                return 2;
            case 'a': case 'e': case 'i': case 'o': case 'u': case 'l': case 'n': case 'r': case 's': case 't': 
                return 1;
            
            default:
                throw new ArgumentOutOfRangeException();
        }


    }
    
}