using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDeskWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        public IndexModel(MegaDeskWeb.Models.MegaDeskWebContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; }//creada automáticamente
        public string SearchString { get; set; }//contiene lo que el user inrgesa en el textbox
        public string MaterialString { get; set; }



        public async Task OnGetAsync(string searchString, string materialString)
        {

            var quotes = from m in _context.Quote
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                quotes = quotes.Where(s => s.Name.Contains(searchString));
            }

            
            else if (!String.IsNullOrEmpty(materialString))
            {
                quotes = quotes.Where(s => s.Material.Contains(materialString));
            }

            Quote = await quotes.ToListAsync();
            SearchString = searchString;
            MaterialString = materialString;
        }
       
        }
    }




