using Demo.DesignPattern.Rules;
using static Demo.DesignPattern.Rules.Message;

Message message = new() { 
    Id = 1, Body = "Just wanted to say Hi", Sender = "mohammed", Priority = PriorityLevel.Low
};

var isEligible = MessageEligibilityChecker.IsEligible(message);
Console.WriteLine($"Is eligible: {isEligible}");

Console.WriteLine("\nPress any key to exit.");
