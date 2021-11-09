using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DesignPattern.Rules
{
    public class Message
    {
        public int Id { get; set; }
        public string? Body { get; set; }
        public string? Sender { get; set; }

        public PriorityLevel Priority { get; set; } = PriorityLevel.Normal;
        public enum PriorityLevel
        { 
            Low = 0,
            Normal = 1,
            High = 2,
        }
    }
}
