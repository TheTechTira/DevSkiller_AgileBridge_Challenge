using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApplicationClientModule.Model
{
    [Table("BankAccount")]
    public class BankAccount
    {
        [Key]
        public int Id { get; set; }

        public string AccountNumber { get; set; }

        public int ClientId { get; set; }

        public BankClient Client { get; set; }
    }
}
