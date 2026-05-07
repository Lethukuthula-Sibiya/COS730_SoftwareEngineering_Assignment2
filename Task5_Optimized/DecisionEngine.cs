public class DecisionEngine
{
    public string EvaluateDecision(double average, bool consensus)
    {
        Console.WriteLine("DecisionEngine: Evaluating decision...");

        if (average >= 75 && consensus)
            return "accepted";

        if (average < 50)
            return "rejected";

        return "revision";
    }
}