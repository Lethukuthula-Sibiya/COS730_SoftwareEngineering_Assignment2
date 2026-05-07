public class SubmissionController
{
    private Validator validator = new Validator();
    private Database database = new Database();
    private ReviewerManager reviewerManager = new ReviewerManager();
    private EvaluationManager evaluationManager = new EvaluationManager();
    private NotificationService notificationService = new NotificationService();

    public void Submit(string data)
    {
        bool valid = validator.ValidateFormat(data);

        if (!valid)
        {
            Console.WriteLine("Submission Error: Invalid Format");
            return;
        }

        database.SaveSubmission(data);

        var reviewers = reviewerManager.GetAvailableReviewers();
        reviewers = reviewerManager.FilterConflicts(reviewers);
        reviewers = reviewerManager.CheckWorkload(reviewers);

        foreach (var reviewer in reviewers)
        {
            reviewerManager.AssignReview(reviewer);
        }

        evaluationManager.StartEvaluation();

        foreach (var reviewer in reviewers)
        {
            int score = reviewer.SubmitScore();
            database.SaveScore(score);
        }

        double average = evaluationManager.CalculateAverage();
        bool consensus = evaluationManager.CheckConsensus();

        string decision = evaluationManager.ApplyRules(average, consensus);

        switch (decision)
        {
            case "accepted":
                notificationService.NotifyAcceptance();
                break;
            case "rejected":
                notificationService.NotifyRejection();
                break;
            case "revision":
                notificationService.NotifyRevision();
                break;
        }

        notificationService.SendNotification();
    }
}