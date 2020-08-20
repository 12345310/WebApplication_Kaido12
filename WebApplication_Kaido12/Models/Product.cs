using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Kaido12.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StandardPrice { get; set; }
        public int ListPrice { get; set; }
    }
}