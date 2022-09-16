using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] numberToList = phoneNumber.Split('-');
        
        bool IsNewYork = false; 
        bool IsFake = false;
        string LocalNumber = numberToList[2];
        

        if (numberToList[0] == "212"){
            IsNewYork = true;
        }
        if(numberToList[1]== "555"){
            IsFake = true;
        }
   
    
        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        // Console.WriteLine(Analyze(phoneNumberInfo));
        
        return phoneNumberInfo.Item2;
    }
}
