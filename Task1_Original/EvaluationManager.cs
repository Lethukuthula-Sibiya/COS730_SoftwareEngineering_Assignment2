public class EvaluationManager
{
    public void StartEvaluation()
    {
        Console.WriteLine("EvaluationManager: Starting evaluation...");
    }

    public double CalculateAverage()
    {
        Console.WriteLine("EvaluationManager: Calculating average...");
        return 78.5;
    }

    public bool CheckConsensus()
    {
        Console.WriteLine("EvaluationManager: Checking consensus...");
        return true;
    }

    public string ApplyRules(double average, bool consensus)
    {
        Console.WriteLine("EvaluationManager: Applying decision rules...");

        if (average >= 75 && consensus)
            return "accepted";

        if (average < 50)
            return "rejected";

        return "revision";
    }
}