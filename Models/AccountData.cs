using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace AccountDetails.Models
{
    public class AccountData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountNumber {get; set;}
        public string? Name {get; set;}
        public double CurrentBalance {get; set;}
    }
}