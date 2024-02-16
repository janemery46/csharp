using System;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        identifier = Regex.Replace(identifier, " ", "_");
        identifier = Regex.Replace(identifier, "\0", "CTRL");
        identifier = Regex.Replace(identifier, @"-\D", new MatchEvaluator(CamelCasing));
        return Regex.Replace(identifier, @"[α-ω]|\d|\W", "");    
    }

    private static string CamelCasing(Match match) => match.Value[1].ToString().ToUpper();
}
