using System;
using System.ComponentModel.DataAnnotations;

namespace CardLibrary.Data.Models
{
    public class Card
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
       
        //public CardGroup cardGroup { get; set; }
        //public UserCard UserCard { get; set; }        

    }
}
