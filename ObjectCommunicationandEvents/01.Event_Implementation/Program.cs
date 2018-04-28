using System;

class Program
{
    static void Main(string[] args)
    {
        INameChangeble dispatcer = new Dispacher("Pesho");
        INameChangeHandler handler = new Handler();
        dispatcer.NameChange += handler.OnDispacherNameChange;
        string input;
        while ((input = Console.ReadLine())!= "End")
        {
            dispatcer.Name = input;
        }
    }
}