public class NotificationService
{
    public void NotifyAcceptance()
    {
        Console.WriteLine("Notification: Accepted");
    }

    public void NotifyRejection()
    {
        Console.WriteLine("Notification: Rejected");
    }

    public void NotifyRevision()
    {
        Console.WriteLine("Notification: Revision Required");
    }

    public void SendNotification()
    {
        Console.WriteLine("Notification sent.");
    }
}