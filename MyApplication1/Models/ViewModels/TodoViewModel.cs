using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApplication1.Models.ViewModels
{
    public class TodoViewModel
    {
        public List<Todo> Todos { get; set; }
        public Todo Todo { get; set; }
        public IEnumerable<Category> Categories {get; set;}
    }
}