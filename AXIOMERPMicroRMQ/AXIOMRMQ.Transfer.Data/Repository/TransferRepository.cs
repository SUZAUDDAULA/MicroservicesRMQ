using AXIOMRMQ.Transfer.Domain.Interfaces;
using AXIOMRMQ.Transfer.Data.Context;
using AXIOMRMQ.Transfer.Domain.Models;
using System.Collections.Generic;

namespace AXIOMRMQ.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }
    }
}
