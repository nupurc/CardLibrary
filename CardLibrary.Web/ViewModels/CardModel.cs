using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardLibrary.Web.ViewModels
{
    public class CardModel
    {
        public int CardId { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public string ShortUrl { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public byte[] CardImage { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
