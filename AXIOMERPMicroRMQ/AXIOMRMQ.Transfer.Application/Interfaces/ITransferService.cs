using AXIOMRMQ.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AXIOMRMQ.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
