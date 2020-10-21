using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LR3_4.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Phone> Phones { get; set; }

        public Category(string categorypName)
        {
            CategoryName = categorypName;
        }
        public Category()
        {
            Phones = new List<Phone>();
        }
    }
}