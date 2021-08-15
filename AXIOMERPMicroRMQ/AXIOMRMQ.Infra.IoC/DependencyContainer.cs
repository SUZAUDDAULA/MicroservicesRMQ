using AXIOMMicroRMQ.Domain.Core.Bus;
using AXIOMMicroRMQ.Infra.Bus;
using AXIOMRMQ.Banking.Application.Interfaces;
using AXIOMRMQ.Banking.Application.Services;
using AXIOMRMQ.Banking.Data.Context;
using AXIOMRMQ.Banking.Data.Repository;
using AXIOMRMQ.Banking.Domain.CommandHandlers;
using AXIOMRMQ.Banking.Domain.Commands;
using AXIOMRMQ.Banking.Domain.Interfaces;
using AXIOMRMQ.Transfer.Data.Context;
using MediatR;
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

            //Domain Banking Command
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool>, TransferCommandHandler>();
            
            //Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();

            services.AddTransient<TransferDbContext>();
        }
    }
}
