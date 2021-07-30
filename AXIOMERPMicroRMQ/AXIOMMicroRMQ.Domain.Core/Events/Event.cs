using System;
using System.Collections.Generic;
using System.Text;

namespace AXIOMMicroRMQ.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestemt { get; protected set; }

        protected Event()
        {
            Timestemt = DateTime.Now;
        }
    }
}
