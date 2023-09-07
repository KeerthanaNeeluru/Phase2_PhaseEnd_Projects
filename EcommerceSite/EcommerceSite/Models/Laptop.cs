using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EcommerceSite.Models
{
    [Table("Laptop")]
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        public string Company { get;set; }
        public  string ModelName { get;set; }
        public double Price { get;set; }
    }
}