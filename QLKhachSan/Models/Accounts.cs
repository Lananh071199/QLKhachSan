using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLKhachSan.Models
{
    [Table("Accounts")]
    public class Accounts
    {
        [Key]
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        //Định nghĩa DataTypr
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}