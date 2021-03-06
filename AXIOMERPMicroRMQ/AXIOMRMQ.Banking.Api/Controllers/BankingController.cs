using AXIOMRMQ.Banking.Application.Interfaces;
using AXIOMRMQ.Banking.Application.Models;
using AXIOMRMQ.Banking.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXIOMRMQ.Banking.Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Account>> GetAllAccount()
        {
            var result = _accountService.GetAccounts();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AccountTransfer([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }

    }
}
