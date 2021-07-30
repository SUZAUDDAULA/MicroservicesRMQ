using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AXIOMMicroRMQ.Domain.Core.Events
{
    public class Message:IRequest<bool>
    {
        public string MessageType { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
