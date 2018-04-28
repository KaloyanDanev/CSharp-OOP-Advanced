using System;

public class Handler:INameChangeHandler
{
    public void OnDispacherNameChange(object sender, NameChangeEventArgs args)
    {
        Console.WriteLine($"Dispatcher's name changed to {args.Name}.");
    }
}