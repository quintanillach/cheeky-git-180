using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    // The Person class provides all of the methods
    // and properties available for implementation
    public abstract class Person
    {
        // These are partial implementations of properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public abstract float ComputeGradeAverage();

        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine($"Dear {FirstName},");
            sb.AppendLine(message);

            return sb.ToString();
        }
    }
}
