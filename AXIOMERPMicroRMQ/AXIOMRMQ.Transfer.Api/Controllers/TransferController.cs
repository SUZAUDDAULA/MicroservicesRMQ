using AXIOMRMQ.Transfer.Application.Interfaces;
using AXIOMRMQ.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXIOMRMQ.Transfer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class TransferController : ControllerBase
    {

        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> GetTransferLogs()
        {
            var result = _transferService.GetTransferLogs();
            return Ok(result);
        }
    }
}
