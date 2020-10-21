using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LR3_4.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Mark { get; set; }
       
        public string Price { get; set; }


        public int? CategoryId { get; set; }
        public Category CN1 { get; set; }
        public string getcat()
        {
            return this.CN1.CategoryName;
        }
    }
}