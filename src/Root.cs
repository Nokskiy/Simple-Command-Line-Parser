namespace SCLP;

public class Root(string[] args,OptionsList optionsList)
{
    internal Parser Parser { get; private set; } = new Parser(args,optionsList);

    public void ParseOptions() => Parser.Parse();
    
    public void InvokeActions()
    {
        foreach (var opt in optionsList.Options)
            if(opt.Activated)
                opt.Action?.Invoke(opt.Arguments);
    }

    public void PrintHelp(string[]? arguments)
    {
        foreach(var opt in optionsList.Options)
        {
            if (opt.ShortName != null)
                Console.Write($"-{opt.ShortName}");
            if (opt.FullName != null)
                Console.Write($", --{opt.FullName}");
            if(opt.ArgumentsExample != null)
                Console.Write($", <{opt.ArgumentsExample}> ");
            if (opt.Description != null)
                Console.WriteLine($" | {opt.Description}");
            else
                Console.WriteLine();
        }
    }
}
