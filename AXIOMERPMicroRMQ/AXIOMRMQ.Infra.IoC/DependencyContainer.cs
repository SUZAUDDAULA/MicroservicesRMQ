using AXIOMMicroRMQ.Domain.Core.Bus;
using AXIOMMicroRMQ.Infra.Bus;
using AXIOMRMQ.Banking.Application.Interfaces;
using AXIOMRMQ.Banking.Application.Services;
using AXIOMRMQ.Banking.Data.Context;
using AXIOMRMQ.Banking.Data.Repository;
using AXIOMRMQ.Banking.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AXIOMRMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, AXIOMRMQBus>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
