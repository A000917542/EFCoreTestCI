using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFCoreTest.Data;
using EFCoreTest.Models;

namespace EFCoreTest.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly EFCoreTest.Data.EFCoreTestContext _context;

        public IndexModel(EFCoreTest.Data.EFCoreTestContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Posts
                .Include(p => p.Blog).ToListAsync();
        }
    }
}
