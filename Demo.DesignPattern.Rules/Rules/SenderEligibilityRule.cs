using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DesignPattern.Rules
{
    public class SenderEligibilityRule : IMessageEligibilityRule
    {
        private string[] AllowedSenders { get; set; }

        public SenderEligibilityRule(string[] senders) => AllowedSenders = senders;

        public bool IsEligible(Message message)
        {
            return AllowedSenders.Contains(message.Sender);
        }
    }
}
