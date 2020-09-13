using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardLibrary.Web.ViewModels
{
    public class UserCardModel
    {
        public int UserCardId { get; set; }
        public int CardId { get; set; }
        public int UserId { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
