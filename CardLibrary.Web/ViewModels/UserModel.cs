using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardLibrary.Web.ViewModels
{
    public class UserModel
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

        public int UserRoleModelId { get; set; }
        public int UserGroupModelId { get; set; }
    }
}
