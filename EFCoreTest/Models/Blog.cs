using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTest.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        
        [Url]
        public string Url { get; set; }

        [Range(minimum:1, maximum: 5)]
        public int Rating { get; set; }

        public string BlogName { get; set; }
        
        public List<Post> Posts { get; set; }
    }
}
