namespace Demo.DesignPattern.Rules
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static Demo.DesignPattern.Rules.Message;

    public class MessageEligibilityChecker
    {
        public static bool IsEligible(Message message)
        {
            var isEligible = false;

            var rules = new List<IMessageEligibilityRule>
            {
                new SenderEligibilityRule(new string[] {"mohammed"}),
                new PriorityEligibilityRule(new PriorityLevel[] {PriorityLevel.High})
            };

            isEligible = rules.All(x => x.IsEligible(message));

            return isEligible;
        }
    }
}
