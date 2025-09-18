public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) 
    {
        string result = shirtNum switch
        {
                1 => "goalie",
                2 => "left back",
                3 or 4 => "center back",
                5 => "right back",
                6 or 7 or 8 => "midfielder",
                9 => "left wing",
                10 => "striker",
                11 => "right wing",
                _ => "UNKNOWN"
        };
        return result;
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int fans:
                return $"There are {fans} supporters at the match.";
            case string announcement:
                return announcement;
            case Injury injury:
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";
            case Incident incident:
                return incident.GetDescription();
            case Manager manager:
                return $"{manager.Name}{(manager.Club == null ? "" : $" ({manager.Club})")}";
            default:
                return "";
        }
    }
}
