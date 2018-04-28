using System;

public class Dispacher : INameChangeble,IDispatcher
{
    public event NameChangeEventHandler NameChange;
    private string name;

    public Dispacher(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get
        {
            return this.name;

        }
        set
        {
            this.OnNameChange(new NameChangeEventArgs(value));
            this.name = value;
        }
    }
    public void OnNameChange(NameChangeEventArgs args)
    {
        if (this.NameChange != null) 
        {
            this.NameChange.Invoke(this,args);
        }
    }
}
