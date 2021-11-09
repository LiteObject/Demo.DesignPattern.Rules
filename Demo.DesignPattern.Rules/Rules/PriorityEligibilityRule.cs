namespace Demo.DesignPattern.Rules
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static Demo.DesignPattern.Rules.Message;

    public class PriorityEligibilityRule : IMessageEligibilityRule
    {
        private PriorityLevel[] AllowedPriorities { get; set; }

        public PriorityEligibilityRule(PriorityLevel[] priorities) => AllowedPriorities = priorities;

        public bool IsEligible(Message message)
        {
            return AllowedPriorities.Contains(message.Priority);
        }
    }
}
