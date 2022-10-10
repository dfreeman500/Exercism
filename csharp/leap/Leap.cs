using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool value = false;
       
        if (year % 4 == 0 ){
            value = true;
            if (year % 100 == 0 && year % 400 !=0){
                value= false;
            }
        }
        return value;
    }
}
