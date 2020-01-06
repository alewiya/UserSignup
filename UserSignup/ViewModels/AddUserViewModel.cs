using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {
      [Required]
        public string UserName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20,MinimumLength =6,ErrorMessage =" It is InValid password")]
        public string Password { get; set; }
        [Required]
        //[Compare("Password",ErrorMessage ="Password don't match")]
        public int Verfiy { get; set; }
    public AddUserViewModel() { }
    }
}
