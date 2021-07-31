using System;
using System.Collections.Generic;
using System.Text;

namespace AXIOMRMQ.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
