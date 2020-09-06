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
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }

        public bool isActive { get; set; }

        public UserRole UserRole { get; set; }
        public UserGroup UserGroup { get; set; }
    }
}
