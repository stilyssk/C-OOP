using System;

namespace Stealer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Spy spy = new Spy();
            Hacker hacker = new Hacker();
            string result = spy.StealFieldInfo("Hacker", "username", "password");
            Type typeInformation = Type.GetType("C:\\C#OOP\\C-OOP\ver02\\OOPReflectionAndAttributesLab\\Stealer\\Hacker");
            Type typeInformation1 = Type.GetType(hacker.GetType().Name);
            var test = hacker.GetType();

        }
    }
}
