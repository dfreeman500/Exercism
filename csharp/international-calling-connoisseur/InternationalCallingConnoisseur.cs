using System;
using System.Collections.Generic;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>{{1, "United States of America"}, {55, "Brazil"},{91, "India"}};
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var dictionary = GetEmptyDictionary();
        dictionary.Add(countryCode, countryName);
        return dictionary;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        var dictionary = GetExistingDictionary();
        dictionary.Add(countryCode, countryName);
        return dictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        
        return existingDictionary.ContainsKey(countryCode) ? existingDictionary[countryCode]: "";

        
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (CheckCodeExists(existingDictionary, countryCode)){
            existingDictionary[countryCode] = countryName;
            
        }
        return existingDictionary;
        
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary; 
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        int index = 0;
        int size = 0; 

        foreach(var item in existingDictionary)
        {
            if (item.Value.Length>size){
                size = item.Value.Length;
                index = item.Key;
            }
        }
        
        return size>0 ? existingDictionary[index]: "";
    }
}