using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DropDownList.Model;
using Microsoft.EntityFrameworkCore;



namespace DropDownList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly  ConnectionStringClass _db;

        public IndexModel(ConnectionStringClass db)
        {
            _db = db;
        }
        public IEnumerable<DspClass>  DisplayData { get; set; }

        public async Task OnGet()
        {
            DisplayData = await _db.Dispute.ToListAsync();

        }
    }
}
