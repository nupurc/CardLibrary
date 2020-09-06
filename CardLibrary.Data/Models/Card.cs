using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Text;

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
       
        public CardGroup cardGroup { get; set; }
        public UserCard UserCard { get; set; }        

    }
}
