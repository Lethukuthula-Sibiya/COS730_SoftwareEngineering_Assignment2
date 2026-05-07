public class SubmissionUI
{
    private SubmissionController controller = new SubmissionController();

    public void Submit(string data)
    {
        Console.WriteLine("UI: Forwarding submission...");
        controller.Submit(data);
    }
}