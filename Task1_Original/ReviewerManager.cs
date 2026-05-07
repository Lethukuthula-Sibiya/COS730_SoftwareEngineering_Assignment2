public class ReviewerManager
{
    public List<Reviewer> GetAvailableReviewers()
    {
        Console.WriteLine("ReviewerManager: Getting available reviewers...");
        return FetchReviewers();
    }

    public List<Reviewer> FetchReviewers()
    {
        Console.WriteLine("ReviewerManager: Fetching reviewers...");
        return new List<Reviewer>
        {
            new Reviewer(),
            new Reviewer(),
            new Reviewer()
        };
    }

    public List<Reviewer> FilterConflicts(List<Reviewer> reviewers)
    {
        Console.WriteLine("ReviewerManager: Filtering conflicts...");
        return reviewers;
    }

    public List<Reviewer> CheckWorkload(List<Reviewer> reviewers)
    {
        Console.WriteLine("ReviewerManager: Checking workload...");
        return reviewers;
    }

    public void AssignReview(Reviewer reviewer)
    {
        Console.WriteLine("ReviewerManager: Assigning reviewer...");
    }
}