using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary.Data.Models
{
  public  class UserCard
    {
        public int UserCardId { get; set; }
        public int CardId { get; set; }
        public int UserId { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
