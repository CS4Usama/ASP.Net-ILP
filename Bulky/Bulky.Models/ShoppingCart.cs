﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BulkyBook.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int Count { get; set; }

        public int ProductId {  get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]
        public Product Product { get; set; }
        [Range(1, 100, ErrorMessage = "Please Enter A Value Between 1 and 100.")]

        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }

        [NotMapped]
        public double Price { get; set; }
    }
}
