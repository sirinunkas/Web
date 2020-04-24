using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ParameterAccounts
    {
        public int test { get; set; }
    }
    public class Accounts
    {
        [Key]
        public int accountAutoSeq { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public bool isActive { get; set; }
        public bool isDelete { get; set; }

    }

    
}