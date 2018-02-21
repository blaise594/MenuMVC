using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; } = true;
        public DateTime DateAdded {get; set; }
    }
    public enum Category
    {
        Appetizer,
        Entree,
        Dessert
    }
    
}
