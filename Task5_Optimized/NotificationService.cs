public class NotificationService
{
    public void SendNotification(string decision)
    {
        Console.WriteLine($"Notification: {decision.ToUpper()}");
    }
}