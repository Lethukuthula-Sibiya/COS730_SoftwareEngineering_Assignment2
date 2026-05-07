public class Reviewer
{
    private static Random random = new Random();

    public int SubmitScore()
    {
        int score = random.Next(50, 101);
        Console.WriteLine($"Reviewer submitted score: {score}");
        return score;
    }
}