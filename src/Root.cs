namespace SCLP;

public class Root(string[] args,OptionsList optionsList)
{
    public Parser Parser { get; private set; } = new Parser(args,optionsList);

    public void ParseOptions()
    {
        Parser.Parse();
    }
}
