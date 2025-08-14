namespace SCLP;

public class Option(string? shortName, string fullName, string? description,bool acceptArgs = false,string? argumentsExample = null!)
{
    internal bool Activated = false;
    internal string? ArgumentsExample => argumentsExample;
    internal bool AcceptArgs => acceptArgs;
    internal string? ShortName => shortName;
    internal string FullName => fullName;
    internal string? Description => description;
    internal string[]? Arguments;

    public delegate void ActionDelegate(string[]? arguments);

    public ActionDelegate? Action;
}