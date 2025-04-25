using System;

/*
1) In first example , there is vioalated Single responsibility , because reason class does more than one thing , solution is second.
*/

/*
2) There is ok
*/

/*
3) There is violated Open/Closed principle and every time we add new shape we have to modify AreaCalculator , solution is 4)

4) There is ok
*/

/*
5) Notification depends on EmailService and there is violated Dependency Inversion principle and we can't switch to telegram or sms notifications
solution =>
*/

public interface IMessageSender
{
    void Send(string message);
}

public class EmailService : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}

public class Notification
{
    private IMessageSender sender;

    public Notification(IMessageSender sender)
    {
        this.sender = sender;
    }

    public void Alert(string message)
    {
        sender.Send(message);
    }
}


