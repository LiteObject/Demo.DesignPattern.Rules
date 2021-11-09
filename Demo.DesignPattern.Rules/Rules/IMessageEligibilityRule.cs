using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DesignPattern.Rules
{
    public interface IMessageEligibilityRule
    {
        bool IsEligible(Message message);
    }
}
