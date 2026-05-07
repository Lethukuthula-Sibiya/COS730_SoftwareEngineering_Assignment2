public class ReviewerManager
{
    public List<Reviewer> AssignEligibleReviewers()
    {
        Console.WriteLine("ReviewerManager: Assigning eligible reviewers...");

        var reviewers = FetchReviewers();
        reviewers = FilterConflicts(reviewers);
        reviewers = CheckWorkload(reviewers);

        foreach (var reviewer in reviewers)
        {
            AssignReview(reviewer);
        }

        return reviewers;
    }

    private List<Reviewer> FetchReviewers()
    {
        return new List<Reviewer>
        {
            new Reviewer(),
            new Reviewer(),
            new Reviewer()
        };
    }

    private List<Reviewer> FilterConflicts(List<Reviewer> reviewers)
    {
        return reviewers;
    }

    private List<Reviewer> CheckWorkload(List<Reviewer> reviewers)
    {
        return reviewers;
    }

    private void AssignReview(Reviewer reviewer)
    {
        Console.WriteLine("Reviewer assigned.");
    }
}