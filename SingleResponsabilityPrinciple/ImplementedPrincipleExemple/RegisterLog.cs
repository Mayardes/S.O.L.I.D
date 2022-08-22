using System;

namespace SingleResponsabilityPrinciple.ImplementedPrincipleExemple
{
    public class RegisterLog : ILogger
    {
        public void Info(string info, string error = "")
        {
            Console.WriteLine($"{info} - {error}");
        }
    }
}
