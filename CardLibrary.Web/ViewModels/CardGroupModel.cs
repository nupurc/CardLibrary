using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardLibrary.Web.ViewModels
{
    public class CardGroupModel
    {
        public int CardGroupId { get; set; }
        public int CardId { get; set; }
        public int GroupId { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
