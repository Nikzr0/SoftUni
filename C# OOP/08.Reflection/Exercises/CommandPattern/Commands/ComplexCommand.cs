using CommandPattern.Core.Contracts;

namespace CommandPattern.Commands
{
    public class ComplexCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return $"Complex command {args[0]} {args[1]}";
        }
    }
}
