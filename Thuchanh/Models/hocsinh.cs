using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Thuchanh.Models
{
    public class hocsinh
    {
        [Key]
        public int ID { get; set; }
   
        public string name { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "từ 3 đến 30 ký tự")]
        public string address { get; set; }
        
    }
}