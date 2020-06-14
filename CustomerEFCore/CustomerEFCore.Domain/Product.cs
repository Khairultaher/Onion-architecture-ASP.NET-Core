﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerEFCore.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

    }
}