using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CardLibrary.Data.Models
{
   public class User
    {
        public int UserId { get; set; }

        [MaxLength(10)]
        public string UsertName { get; set; }

        public string password { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }

        public bool isActive { get; set; }

        public int UserRoleId { get; set; }
        public int UserGroupId { get; set; }
    }
}
