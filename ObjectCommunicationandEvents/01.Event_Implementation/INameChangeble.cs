public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
public interface INameChangeble
{
    string Name { get; set; }
    event NameChangeEventHandler NameChange;
    void OnNameChange(NameChangeEventArgs args);
}