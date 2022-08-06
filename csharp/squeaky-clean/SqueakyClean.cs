using System;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        
        identifier = identifier.Replace(' ', '_');
        identifier = identifier.Replace("\0", "CTRL");
        for (int i=0; i<identifier.Length; i++){
            if (identifier[i]=='-'){
                identifier= identifier.Replace(identifier[i+1], char.ToUpper(identifier[i+1]));
            }
        }
        identifier = identifier.Replace("-", "");
        identifier = identifier.Replace("😀", "");
        identifier = Regex.Replace(identifier, @"[\d-]", "");
        identifier = Regex.Replace(identifier, @"[α-ω]", "");

        return identifier;
    }
}
