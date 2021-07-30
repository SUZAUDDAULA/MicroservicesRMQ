using AXIOMMicroRMQ.Domain.Core.Bus;
using AXIOMMicroRMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AXIOMRMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Domain Bus
            service.AddTransient<IEventBus, AXIOMRMQBus>();
        }
    }
}
