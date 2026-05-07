public class EvaluationManager
{
    private Database database = new Database();
    private DecisionEngine decisionEngine = new DecisionEngine();

    public string EvaluateSubmission(List<Reviewer> reviewers)
    {
        Console.WriteLine("EvaluationManager: Evaluating submission...");

        List<int> scores = new List<int>();

        foreach (var reviewer in reviewers)
        {
            int score = reviewer.SubmitScore();
            database.SaveScore(score);
            scores.Add(score);
        }

        double average = CalculateAverage(scores);
        bool consensus = CheckConsensus(scores);

        return decisionEngine.EvaluateDecision(average, consensus);
    }

    private double CalculateAverage(List<int> scores)
    {
        return scores.Average();
    }

    private bool CheckConsensus(List<int> scores)
    {
        return true;
    }
}