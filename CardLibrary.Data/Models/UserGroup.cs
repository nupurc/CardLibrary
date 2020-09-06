using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CardLibrary.Data.Models
{
   public class UserGroup
    {
        public int UserGroupId { get; set; }
        [MaxLength(100)]
        public string GroupName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public bool IsActive { get; set; }

    }
}
