using System;
using System.Collections.Generic;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        var  colorList = new List<string>(){
            "black",
            "brown",
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "violet",
            "grey",
            "white"
    
            };


        return int.Parse(string.Concat(colorList.FindIndex(a => a.Contains(colors[0])),(colorList.FindIndex(a => a.Contains(colors[1])))));
            
              
    }
}


// 1.find the index of the first 2 colors of the colors array
// 2. concatenate them
// 3. Turn the string into an int