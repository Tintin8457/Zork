using System;
using Zork;

namespace Zork
{
    internal class ConsoleOuputService : IOutputService
    {
        public void Clear() => Console.Clear();


        public void Write(string value) => Write(value.ToString());
        public void WriteLine(string value) => WriteLine(value.ToString());

        public void Write(object value) => Console.Write(value);
        public void WriteLine(object value) => Console.WriteLine(value);
    }
}
