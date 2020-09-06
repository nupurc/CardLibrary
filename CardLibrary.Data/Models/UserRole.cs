using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CardLibrary.Data.Models
{
   public class UserRole
    {
        public int UserRoleId { get; set; }

        [MaxLength(30)]
        public string RoleName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool isActive { get; set; }

    }
}
