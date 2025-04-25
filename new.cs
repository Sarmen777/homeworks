using System;
using System.Collections.Generic;

public class NotificationMessage
{
    public string Title { get; set; }
    public string Body { get; set; }
    public string Recipient { get; set; }

    public NotificationMessage(string title, string body, string recipient)
    {
        Title = title;
        Body = body;
        Recipient = recipient;
    }
}
public interface INotificationSender
{
    void Send(NotificationMessage message);
}

public class EmailSender : INotificationSender
{
    public void Send(NotificationMessage message)
    {
        Console.WriteLine($"[Email] To: {message.Recipient}\nTitle: {message.Title}\nBody: {message.Body}");
    }
}

public class SmsSender : INotificationSender
{
    public void Send(NotificationMessage message)
    {
        Console.WriteLine($"[SMS] To: {message.Recipient}\nBody: {message.Body}");
    }
}

public class PushNotificationSender : INotificationSender
{
    public void Send(NotificationMessage message)
    {
        Console.WriteLine($"[Push] To: {message.Recipient}\nTitle: {message.Title}\nBody: {message.Body}");
    }
}
public class TelegramSender : INotificationSender
{
    public void Send(NotificationMessage message)
    {
        Console.WriteLine($"[Telegram] To: {message.Recipient}\nTitle: {message.Title}\nBody: {message.Body}");
    }
}

public class NotificationManager
{
    private readonly List<INotificationSender> senders = new List<INotificationSender>();

    public event Action<NotificationMessage> OnNotificationReady;
    public event Action<DateTime, NotificationMessage> OnNotificationSent;

    public NotificationManager(IEnumerable<INotificationSender> notificationSenders)
    {
        senders.AddRange(notificationSenders);
        OnNotificationReady += SendToAll;
    }

    public void PrepareNotification(NotificationMessage message)
    {
        OnNotificationReady?.Invoke(message);
    }

    private void SendToAll(NotificationMessage message)
    {
        foreach (var sender in senders)
        {
            sender.Send(message);
            OnNotificationSent?.Invoke(DateTime.Now, message);
        }
    }
}

public class Program
{
    public static void Main()
    {
        List<INotificationSender> senders = new List<INotificationSender>
        {
            new EmailSender(),
            new SmsSender(),
            new PushNotificationSender(),
            new TelegramSender() 
        };

        NotificationManager manager = new NotificationManager(senders);

        manager.OnNotificationReady += message =>
        {
            Console.WriteLine($"Notification ready for {message.Recipient}");
        };

        manager.OnNotificationSent += (time, message) =>
        {
            Console.WriteLine($"Sent at {time:HH:mm:ss} to {message.Recipient}");
        };

        NotificationMessage notification = new NotificationMessage(
             "Bank Alert",
             "Your account balance changed by $200.",
             "customer@example.com"
        );

        manager.PrepareNotification(notification);
    }
}