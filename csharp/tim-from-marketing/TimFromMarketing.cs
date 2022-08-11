using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string id1;
        if (id == null){
            id1 = "";
        } else {
            id1 = $"[{id}] - ";
        }

        string department1;
        if (department == null){
            department1 = " - OWNER";
        } else{
            department1 = $" - {department.ToUpper()}";
        }
        
        return id1 + name + department1;
    }
}


// Nice solution here: https://exercism.org/tracks/csharp/exercises/tim-from-marketing/solutions/colinleach

// using System;
// static class Badge
// {
//     public static string Print(int? id, string name, string? department)
//     {
//         var dept = (department ?? "OWNER").ToUpper();
//         return id == null ? $"{name} - {dept}" : $"[{id}] - {name} - {dept}";
//     }
// }