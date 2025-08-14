namespace SCLP;

public class Parser(string[] args,OptionsList options)
{
    private OptionsList _options => options;
    private string[] _args = args;

    public void Parse()
    {
        for (int i = 0; i < _args.Length; i++)
        {
            if (_args[i].ToString()[0].ToString() == "-" && _args[i].ToString()[1].ToString() != "-")
            {
                string optName = _args[i].Remove(0, 1);

                foreach (var opt in _options.Options)
                    if (opt.ShortName == optName)
                    {
                        if(opt.AcceptArgs)
                        {
                            List<string> arguments = new List<string>();

                            GetArgs(i, ref arguments);

                            opt.Arguments = arguments.ToArray();
                        }
                        opt.Activated = true;
                    }
            }
            else if (_args[i].ToString()[0].ToString() == "-" && _args[i].ToString()[1].ToString() == "-")
            {
                string optName = _args[i].Remove(0, 2);

                foreach (var opt in _options.Options)
                    if (opt.FullName == optName)
                    {
                        if (opt.AcceptArgs)
                        {
                            List<string> arguments = new List<string>();

                            GetArgs(i, ref arguments);

                            opt.Arguments = arguments.ToArray();
                        }
                        opt.Activated = true;
                    }
            }
        }

        void GetArgs(int startIndex, ref List<string> arguments)
        {
            for (int i = startIndex + 1; i < _args.Length; i++)
            {
                if (_args[i].ToString()[0].ToString() == "-")
                    break;
                arguments.Add(_args[i].ToString());
            }
        }
    }
}
