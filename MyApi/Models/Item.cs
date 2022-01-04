﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApi.Models
{
    public class Item
    {
        [Key]   //assume identity
        [Column(TypeName = "int")]
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }
        
       
        [Column(TypeName = "decimal")]
        public decimal Price { get; set; }
        
        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }

        
        [Column(TypeName = "nvarchar(20)")]
        public string Genre { get; set; }
    }
}
