using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace HangfireGarden.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
    }
}