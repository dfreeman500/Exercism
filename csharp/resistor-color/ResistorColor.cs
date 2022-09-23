using System;
using System.Collections.Generic;




public static class ResistorColor
{

static List<string> colors = new List<string> {
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
    
    public static int ColorCode(string color)
    {
        return colors.FindIndex(a => a.Contains(color));
    }

    public static string[] Colors()
    {
        return colors.ToArray();;
    }
}