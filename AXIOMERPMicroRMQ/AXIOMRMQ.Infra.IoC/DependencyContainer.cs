using AXIOMMicroRMQ.Domain.Core.Bus;
using AXIOMMicroRMQ.Infra.Bus;
using AXIOMRMQ.Banking.Application.Interfaces;
using AXIOMRMQ.Banking.Application.Services;
using AXIOMRMQ.Banking.Data.Context;
using AXIOMRMQ.Banking.Data.Repository;
using AXIOMRMQ.Banking.Domain.CommandHandlers;
using AXIOMRMQ.Banking.Domain.Commands;
using AXIOMRMQ.Banking.Domain.Interfaces;
using AXIOMRMQ.Transfer.Application.Interfaces;
using AXIOMRMQ.Transfer.Application.Services;
using AXIOMRMQ.Transfer.Data.Context;
using AXIOMRMQ.Transfer.Data.Repository;
using AXIOMRMQ.Transfer.Domain.EventHandlers;
using AXIOMRMQ.Transfer.Domain.Events;
using AXIOMRMQ.Transfer.Domain.Interfaces;
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
            services.AddSingleton<IEventBus, AXIOMRMQBus>(sp=>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new AXIOMRMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            services.AddTransient<TransferEventHandler>();

            //Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            //Domain Banking Command
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool>, TransferCommandHandler>();
            
            //Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<TransferDbContext>();
            services.AddTransient<BankingDbContext>();

            
        }
    }
}
