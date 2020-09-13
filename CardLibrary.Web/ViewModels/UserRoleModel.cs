using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardLibrary.Web.ViewModels
{
    public class UserRoleModel
    {
        public int UserRoleId { get; set; }

        [MaxLength(30)]
        public string RoleName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool isActive { get; set; }
    }
}
