using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SoccerFieldManager.Entities
{
    public class UserEntity
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "FisrtsName is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "CellPhone is required")]
        public long CellPhone { get; set; }

        [Required(ErrorMessage = "CellPhoneT is required")]
        public long CellPhoneT { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}
