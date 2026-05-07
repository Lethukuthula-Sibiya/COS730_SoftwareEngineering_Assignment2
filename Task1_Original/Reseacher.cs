public class Researcher
{
    private SubmissionUI ui = new SubmissionUI();

    public void SubmitResearchOutput(string data)
    {
        Console.WriteLine("Researcher: Submitting research output...");
        ui.Submit(data);
    }
}