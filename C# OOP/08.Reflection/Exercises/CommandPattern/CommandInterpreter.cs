using CommandPattern.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public object Activater { get; private set; }

        public string Read(string args)
        {
            string[] arr = args.Split();
            string commandName = arr[0] + "Command";

            Type type = Assembly.GetCallingAssembly().GetTypes()
                .Where(t => t.Name == commandName).FirstOrDefault();

            if (type == null)
            {
                throw new InvalidOperationException("InvlidCommand");
            }

            ICommand command = (ICommand)Activator.CreateInstance(type);// as ICommand

            {
                //string result = string.Empty; // string result = "";
                //ICommand command = null;

                //if (commandName == nameof(HelloCommand))
                //{
                //    command = new HelloCommand();
                //}
                //else if (commandName == nameof(BeepCommand))
                //{
                //    command = new BeepCommand();
                //}
                //else if (commandName == nameof(ComplexCommand))
                //{
                //    command = new ComplexCommand();
                //}
                //else if (commandName == nameof(ExitCommand))
                //{
                //    command = new ExitCommand();
                //}
                //else
                //{
                //    throw new InvalidOperationException("Invalid command!");
                //}
            } // another way!

            string result = command.Execute(arr.Skip(1).ToArray());
            return result;
        }
    }
}
