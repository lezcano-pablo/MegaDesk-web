using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Range(24, 96)]         
        public int Width { get; set; }
        [Range(12, 48)]
        public int Depth { get; set; }
        [Range(0, 7)]
        public int NumOfDrawers { get; set; }
        public string Material { get; set; }

     
        public int RushOrder { get; set; }
        [Display(Name = "Quote Date")]
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }
       
        public decimal TotalAmount { get; set; }

        public int CONSTANT_MAXWIDTH = 96;
        public int CONSTANT_MINWIDTH = 24;



    }
}
