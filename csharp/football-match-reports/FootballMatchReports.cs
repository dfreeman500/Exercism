using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {

        switch (shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case 3:
            case 4:
                return "center back";
            case 5:
                return "right back";
            case 6:
            case 7:
            case 8:
                return "midfielder";
            case 9:
                return "left wing"; 
            case 10:
                return "striker";
            case 11:
                return "right wing";                 
            default:
                throw new ArgumentOutOfRangeException();
        }

    }

    public static string AnalyzeOffField(object report)
    {
            Console.WriteLine(report);
            // if (report == Incident){
            //     Console.WriteLine(Incident);
            // }
        
            switch (report)
        {
                case int:
                    return $"There are {report} supporters at the match.";
                case string:
                    return (string)report;     

                case Injury injury:
                    return "Oh no! " + injury.GetDescription() + " Medics are on the field.";
                    break;

                case Foul foul:
                    
                    return foul.GetDescription();
                    break;
                case Incident incident:
                    return incident.GetDescription();
                    break;

                case Manager manager when manager.Club == null:
                    return manager.Name;
                    break;
                case Manager manager:
                    return manager.Name + " ("+ manager.Club+")";
                    break;
                default:
                    throw new ArgumentException();

                    
        }
        
    }
}
