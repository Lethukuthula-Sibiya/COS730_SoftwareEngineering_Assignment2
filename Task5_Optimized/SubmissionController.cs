public class SubmissionController
{
    private Validator validator = new Validator();
    private Database database = new Database();
    private ReviewerManager reviewerManager = new ReviewerManager();
    private EvaluationManager evaluationManager = new EvaluationManager();
    private NotificationService notificationService = new NotificationService();

    public void Submit(string data)
    {
        // 1. Validation
        if (!validator.ValidateFormat(data))
        {
            Console.WriteLine("Submission Error: Invalid Format");
            return;
        }

        // 2. Save submission
        database.SaveSubmission(data);

        // 3. Assign reviewers (encapsulated)
        var reviewers = reviewerManager.AssignEligibleReviewers();

        // 4. Evaluate submission (encapsulated)
        string decision = evaluationManager.EvaluateSubmission(reviewers);

        // 5. Notify (single call)
        notificationService.SendNotification(decision);
    }
}