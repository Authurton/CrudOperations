﻿namespace CrudOperations.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int IsActive { get; set; }
    }
}
